function printDeckOfCards(cards) {
    let result = [];

    for (let i = 0; i < cards.length; i++) {
        const cardInfo = cards[i];
        
        let face = '';
        let suit = '';

        if (cardInfo.length === 2) {
            face = cardInfo[0];
            suit = cardInfo[1];
        } else if (cardInfo.length === 3) {
            face = cardInfo[0] + cardInfo[1];
            suit = cardInfo[2];
        }

        let card;

        try {
            card = createCard(face, suit);
        } catch (error) {
            console.log(`Invalid card: ${cardInfo}`);
            return;
        }        

        result.push(card.toString());
    }

    console.log(result.join(' '));

    function createCard(face, suit) {
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
} 

printDeckOfCards(['AS', '10D', 'KH', '2P']);