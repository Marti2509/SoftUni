function main(array) {
    let result = [];

    for (let i = 0; i < array.length; i++) {
        let hero = array[i]; // Jake / 1000 / Gauss, HolidayGrenade

        hero = hero.split(' / ');

        let currHero = {
            name: hero[0],
            level: Number(hero[1]),
            items: []
        }

        if (hero.length === 3){
            let items = hero[2].split(', ');

            for (let i = 0; i < items.length; i++) {
                const currItem = items[i];
                
                currHero['items'].push(currItem);
            }
        }

        result.push(currHero);
    }

    console.log(JSON.stringify(result))
}
main(['Jake / 1000 / Gauss, HolidayGrenade']);
main(['Isacc / 25 / Apple, GravityGun', 'Derek / 12 / BarrelVest, DestructionSword', 'Hes / 1 / Desolator, Sentinel, Antara']);