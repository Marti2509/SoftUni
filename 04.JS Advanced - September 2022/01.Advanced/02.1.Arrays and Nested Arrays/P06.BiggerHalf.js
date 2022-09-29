function main(arr) {
    return arr.sort((a, b) => a - b).slice(Math.ceil(arr.length / 2));
}
main([3, 19, 14, 7, 2, 19, 6]);
main([4, 7, 2, 5]);