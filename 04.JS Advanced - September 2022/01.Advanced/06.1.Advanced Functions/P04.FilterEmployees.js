function filter(data, criteria) {
    let parsedData = JSON.parse(data);
    let criteriaArr = criteria.split('-');

    let list = [];

    for (let i = 0; i < parsedData.length; i++) {
        const person = parsedData[i];

        if (criteriaArr[0] === 'all') {
            let result = {
                name: person["first_name"] + ' ' + person["last_name"],
                email: person["email"]
            }

            list.push(result);
        } else if (person[criteriaArr[0]] === criteriaArr[1]) {
            let result = {
                name: person["first_name"] + ' ' + person["last_name"],
                email: person["email"]
            }

            list.push(result);
        }
    }

    for (let i = 0; i < list.length; i++) {
        const person = list[i];
        
        console.log(`${i}. ${person['name']} - ${person['email']}`);
    }
}

filter(`[
    {
        "id": "1",
        "first_name": "Ardine",
        "last_name": "Bassam",
        "email": "abassam0@cnn.com",
        "gender": "Female"
    }, 
    {
        "id": "2",
        "first_name": "Kizzee",
        "last_name": "Jost",
        "email": "kjost1@forbes.com",
        "gender": "Female"
    },
    {
        "id": "3",
        "first_name": "Evanne",
        "last_name": "Maldin",
        "email": "emaldin2@hostgator.com",
        "gender": "Male"
    }]`,
    'gender-Female');

filter(`[
    {
        "id": "1",
        "first_name": "Ardine",
        "last_name": "Bassam",
        "email": "abassam0@cnn.com",
        "gender": "Female"
    }, 
    {
        "id": "2",
        "first_name": "Kizzee",
        "last_name": "Jost",
        "email": "kjost1@forbes.com",
        "gender": "Female"
    },
    {
        "id": "3",
        "first_name": "Evanne",
        "last_name": "Maldin",
        "email": "emaldin2@hostgator.com",
        "gender": "Male"
    }]`,
    'all');