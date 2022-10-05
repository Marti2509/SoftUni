function main(json) {
    let parsed = JSON.parse(json);
    let keys = Object.keys(parsed[0]);

    let result = '<table>\n';

    heading();
    body();

    result += '</table>\n';

    return result;

    //console.log(result);

    function heading() {
        result += '    <tr>';

        for (let columName of keys) {
            result += `<th>${escape(columName)}</th>`;
        }

        result += '</tr>\n';
    }

    function body() {
        for (const item of parsed) {
            result += '    <tr>';

            for (let key of keys) {
                result += `<td>${escape(item[key])}</td>`;
            }

            result += '</tr>\n';
        }
    }

    function escape(value) {
        return value
            .toString()
            .replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
    }
}
main(`[{"Name":"Pesho","Score":4," Grade":8},{"Name":"Gosho","Score":5," Grade":8},{"Name":"Angel","Score":5.50," Grade":10}]`);