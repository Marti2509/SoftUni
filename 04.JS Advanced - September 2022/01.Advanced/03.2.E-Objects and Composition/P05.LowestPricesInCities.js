function main(array) {
    let result = [];
    let allProducts = [];
    let allNames = [];

    for (let i = 0; i < array.length; i++) {
        const info = array[i].split(' | ');

        let town = info[0];
        let product = info[1];
        let price = Number(info[2]);
        
        allProducts.push({
            town: town,
            product: product,
            price: price
        });

        if (!allNames.includes(product)) {
            allNames.push(product);
        }
    }

    for (let i = 0; i < allNames.length; i++) {
        const currName = allNames[i];
        
        let lowestPriceProduct = findTheLowestPriceProductsByName(allProducts, currName);

        result.push(lowestPriceProduct);
    }

    for (let i = 0; i < result.length; i++) {
        const currProduct = result[i];
        
        console.log(`${currProduct['product']} -> ${currProduct['price']} (${currProduct['town']})`);
    }

    function findTheLowestPriceProductsByName(allProducts, name) {
        let allCurrProducts = [];

        for (const product of allProducts) {
            if (product['product'] === name) {
                allCurrProducts.push(product);
            }
        }

        let currLowestPrice = Number.MAX_SAFE_INTEGER;
        let currLowestProductByPrice = {};
        
        for (let i = 0; i < allCurrProducts.length; i++) {
            const currProduct = allCurrProducts[i];
            
            if (currProduct['price'] < currLowestPrice) {
                currLowestPrice = currProduct['price'];
                currLowestProductByPrice = currProduct;
            }
        }

        return currLowestProductByPrice;
    }
}
main(['Sample Town | Sample Product | 1000',
      'Sample Town | Orange | 2',
      'Sample Town | Peach | 1',
      'Sofia | Orange | 3',
      'Sofia | Peach | 2',
      'New York | Sample Product | 1000.1',
      'New York | Burger | 10']);