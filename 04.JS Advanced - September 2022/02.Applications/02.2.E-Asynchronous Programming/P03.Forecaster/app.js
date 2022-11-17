function attachEvents() {
    const locationElement = document.getElementById("location");
    const forecastDiv = document.querySelector('#forecast');
    let locUrl = "http://localhost:3030/jsonstore/forecaster/locations";
    let todaysElement = document.querySelector("#current");
    let upcomingElement = document.querySelector("#upcoming");

    const symbols = {
        'Sunny': '☀',
        'Partly sunny': '⛅',
        'Overcast': '☁',
        'Rain': '☂',
        'Degrees': '°'
    }

    document.getElementById("submit").addEventListener('click', onClick);

    async function onClick() {
        forecastDiv.style.display = 'block';

        todaysElement.lastChild.remove();
        upcomingElement.lastChild.remove();

        let locResponse = await fetch(locUrl);
        let locData = await locResponse.json();

        let code = "";

        for (const item of locData) {
            if (item.name === locationElement.value) {
                code = item.code;
                break;
            }
        }

        let todayUrl = `http://localhost:3030/jsonstore/forecaster/today/${code}`;
        let upcomingUrl = `http://localhost:3030/jsonstore/forecaster/upcoming/${code}`;

        let todayResponse = await fetch(todayUrl);
        let todayData = await todayResponse.json();

        let todayForecastDivElement = document.createElement("div");
        todayForecastDivElement.classList.add("forecasts");

        let todaySymbolSpan = document.createElement("span");
        todaySymbolSpan.classList.add("condition"); 
        todaySymbolSpan.classList.add("symbol"); 
        todaySymbolSpan.textContent = symbols[todayData.forecast.condition];

        let todaySpan = document.createElement("span");
        todaySpan.classList.add("condition");
        
        let todayNameSpan = document.createElement("span");
        todayNameSpan.classList.add("forecast-data");
        todayNameSpan.textContent = todayData.name;

        let todayDegreeSpan = document.createElement("span");
        todayDegreeSpan.classList.add("forecast-data");
        todayDegreeSpan.textContent = todayData.forecast.low + symbols.Degrees + '/' + todayData.forecast.high + symbols.Degrees;

        let todayForecastSpan = document.createElement("span");
        todayForecastSpan.classList.add("forecast-data");
        todayForecastSpan.textContent = todayData.forecast.condition;

        todaySpan.appendChild(todayNameSpan);
        todaySpan.appendChild(todayDegreeSpan);
        todaySpan.appendChild(todayForecastSpan);

        todayForecastDivElement.appendChild(todaySymbolSpan);
        todayForecastDivElement.appendChild(todaySpan);

        todaysElement.appendChild(todayForecastDivElement);

        let upcomingResponse = await fetch(upcomingUrl);
        let upcomingData = await upcomingResponse.json();

        let upcomingForecastDivElement = document.createElement("div");
        upcomingForecastDivElement.classList.add("forecast-info");

        for (let i = 0; i < 3; i++) {
            let data = upcomingData.forecast[i];

            let currUpcomingElement = document.createElement("span");
            currUpcomingElement.classList.add("upcoming");

            let symbolSpan = document.createElement("span");
            symbolSpan.classList.add("symbol"); 
            symbolSpan.textContent = symbols[data.condition];

            let degreeSpan = document.createElement("span");
            degreeSpan.classList.add("forecast-data");
            degreeSpan.textContent = data.low + symbols.Degrees + '/' + data.high + symbols.Degrees;

            let forecastSpan = document.createElement("span");
            forecastSpan.classList.add("forecast-data");
            forecastSpan.textContent = data.condition;

            currUpcomingElement.appendChild(symbolSpan);
            currUpcomingElement.appendChild(degreeSpan);
            currUpcomingElement.appendChild(forecastSpan);

            upcomingForecastDivElement.appendChild(currUpcomingElement);
        }

        upcomingElement.appendChild(upcomingForecastDivElement);
    }
}

attachEvents();