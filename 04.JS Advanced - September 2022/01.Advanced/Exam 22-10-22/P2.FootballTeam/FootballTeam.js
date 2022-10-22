class footballTeam {
    constructor(clubName, country) {
        this.clubName = clubName;
        this.country = country;
        this.invitedPlayers = [];
    }

    newAdditions(footballPlayers) {
        for (const currPlayer of footballPlayers) {
            let name = currPlayer.split('/')[0];
            let age = Number(currPlayer.split('/')[1]);
            let value = Number(currPlayer.split('/')[2]);

            let bool = true;
            let player = {};

            for (const nowPlayer of this.invitedPlayers) {
                if (nowPlayer['name'] === name) {
                    bool = false;
                    player = nowPlayer;
                }
            }

            if (bool) {
                this.invitedPlayers.push({
                    name: name,
                    age: age,
                    value: value
                });
            } else {
                if (player['value'] < value) {
                    player['value'] = value;
                }
            }
        }

        let names = [];

        for (const player of this.invitedPlayers) {
            names.push(player['name']);
        }

        let str = `You successfully invite ${names.join(', ')}.`;
        return str;
    }

    signContract(selectedPlayer) {
        let name = selectedPlayer.split('/')[0];
        let offer = Number(selectedPlayer.split('/')[1]);

        if (!this.invitedPlayers.find(x => x['name'] === name)) {
            throw new Error(`${name} is not invited to the selection list!`);
        } else if (this.invitedPlayers.find(x => x['name'] === name)['value'] > offer) {
            throw new Error(`The manager's offer is not enough to sign a contract with ${name}, ${this.invitedPlayers.find(x => x['name'] === name)['value'] - offer} million more are needed to sign the contract!`);
        } else {
            this.invitedPlayers.find(x => x['name'] === name)['value'] = 'Bought';
            return `Congratulations! You sign a contract with ${name} for ${offer} million dollars.`;
        }
    }

    ageLimit(name, age) {
        if (!this.invitedPlayers.find(x => x['name'] === name)) {
            throw new Error(`${name} is not invited to the selection list!`);
        } else if (this.invitedPlayers.find(x => x['name'] === name)['age'] < age) {
            let diff = age - this.invitedPlayers.find(x => x['name'] === name)['age'];

            if (diff < 5) {
                return `${name} will sign a contract for ${diff} years with ${this.clubName} in ${this.country}!`;
            } else {
                return `${name} will sign a full 5 years contract for ${this.clubName} in ${this.country}!`;
            }
        } else {
            return `${name} is above age limit!`;
        }
    }

    transferWindowResult() {
        let str = "Players list:\n";

        this.invitedPlayers.sort((a, b) => a['name'] - b['name']).forEach(
            player => str += `Player ${player['name']}-${player['value']}\n`
        );

        str = str.trim();

        return str;
    }
}