function main(input) {
    let result = [];

    for (let i = 0; i < input.length; i++) {
        const info = input[i].split(' ');
        
        if (info[0] === 'add') {
            add(info[1]);
        } else if (info[0] === 'remove') {
            remove(info[1]);
        } else if (info[0] === 'print') {
            print();
        }
    }

    function add(string) {
        result.push(string);
    }
    function remove(string) {
        for (let i = 0; i < result.length; i++) {
            const element = result[i];
            
            if (element === string) {
                result.splice(i, 1);
            }
        }
    }
    function print() {
        console.log(result.join(','))
    }
}
main(['add hello', 'add again', 'remove hello', 'add again', 'print']);