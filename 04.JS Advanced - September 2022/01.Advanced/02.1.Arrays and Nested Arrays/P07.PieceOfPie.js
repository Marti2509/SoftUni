function main(arr, first, second) {
    let firstIndex = arr.indexOf(first);
    let secondIndex = arr.indexOf(second, firstIndex);

    return arr.slice(firstIndex, secondIndex + 1);
}
main(['Pumpkin Pie', 'Key Lime Pie', 'Cherry Pie', 'Lemon Meringue Pie', 'Sugar Cream Pie'], 'Key Lime Pie', 'Lemon Meringue Pie');