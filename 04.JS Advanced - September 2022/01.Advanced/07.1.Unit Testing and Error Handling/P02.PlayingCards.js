function main(face, suit) {
    let validFaceCards = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    let validSuitCards = ['S', 'H', 'D', 'C'];
    
    if (!validFaceCards.includes(face)) {
        throw new Error('Error');
    }

    if (!validSuitCards.includes(suit)) {
        throw new Error('Error');
    }
    
    if (suit === 'S') {
        suit = '\u2660';
    } else if (suit === 'H') {
        suit = '\u2665';
    } else if (suit === 'D') {
        suit = '\u2666';
    } else if (suit === 'C') {
        suit = '\u2663';
    }

    return {
        face: face,
        suit: suit,
        toString() {
            return this.face + this.suit;
        },
    }    
}

try {
    console.log(main('A', 'S').toString());
    console.log(main('A', 'g').toString());
} catch (error) {
    console.log(error.message);
}