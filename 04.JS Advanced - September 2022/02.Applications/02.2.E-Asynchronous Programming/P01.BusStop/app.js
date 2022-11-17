async function getInfo() {
    const stopIdElement = document.getElementById("stopId");
    const stopNameElement = document.getElementById("stopName");
    const busesElement = document.getElementById("buses");
    
    const url = `http://localhost:3030/jsonstore/bus/businfo/${stopIdElement.value}`;

    stopIdElement.value = "";
    busesElement.innerHTML = "";

    try {
        let response = await fetch(url);

        if (response.ok === false) {
            throw new Error("Error");
        }

        let data = await response.json();

        stopNameElement.textContent = data.name;

        for (const item in data.buses) {
            let li = document.createElement("li");
            li.textContent = `Bus ${item} arrives in ${data.buses[item]} minutes`;

            busesElement.appendChild(li);
        }
    } catch (e) {
        stopNameElement.textContent = "Error";
    }
}