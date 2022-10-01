function main(array) {
    let outputArr = [];
    let counter = 1;

    for (let i = 0; i < array.length; i++) {
        const command = array[i];
        
        if (command === 'add') {
            outputArr.push(counter);
        } else if (command === 'remove') {
            if (outputArr.length != 0) {
                outputArr.pop();
            }
        } 

        counter++;
    }

    if (outputArr != 0) {
        console.log(outputArr.join('\n'));
    } else {
        console.log('Empty');
    }
}
main(['add', 'add', 'add', 'add']);
main(['add', 'add', 'remove', 'add', 'add']);
main(['remove', 'remove', 'remove', 'remove']);