function solve() {
    const infoElement = document.getElementsByTagName("span")[0];
    const departBtn = document.getElementById("depart");
    const arriveBtn = document.getElementById("arrive");

    let stopName = "";
    let id = "depot"

    async function depart() {
        let url = `http://localhost:3030/jsonstore/bus/schedule/${id}`;

        let response = await fetch(url);
        let data = await response.json();

        id = data.next;
        infoElement.textContent = "Next stop " + data.name;

        stopName = data.name;

        departBtn.disabled = true;
        arriveBtn.disabled = false;
    }

    function arrive() {
        infoElement.textContent = "Arriving at " + stopName;

        departBtn.disabled = false;
        arriveBtn.disabled = true;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();