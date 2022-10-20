function main(input) {
    let data = [];
    let manipulator = manipulaotr();

    for (let order of input) {
        let [cmd, name, secondParam, thirdParam] = order.split(' ');

        if (secondParam === 'inherit') {
            cmd += 'inherit';
        }

        manipulator[cmd](name, thirdParam, secondParam);
    }

    function manipulaotr() {
        let result = {
            create: (name) => data[name] = {},
            createinherit: (name, parentName) => { 
                let obj = Object.create(data[parentName]);
                data[name] = obj;
            },
            set: (name, value, key) => data[name][key] = value,
            print: (name) => {
                let res = [];

                for (let property in data[name]) {
                    res.push(`${property}:${data[name][property]}`)
                }

                console.log(res.join(','))
            }
        }

        return result;
    }
}
