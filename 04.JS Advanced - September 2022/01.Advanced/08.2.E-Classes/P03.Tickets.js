function solve(array, criteria) {

    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = Number(price);
            this.status = status;
        }
    }

    let data = [];

    for (const ticketDescription of array) {

        let [destination, price, status] = ticketDescription.split('|');
        let ticket = new Ticket(destination, price, status);
        data.push(ticket);
    }

    let sorted;

    criteria != 'price' ? sorted = data.sort((a, b) => a[criteria].localeCompare(b[criteria]))
    : sorted = data.sort((a, b) => a[criteria] - b[criteria]);
    return sorted;
}

console.log(solve(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination'));