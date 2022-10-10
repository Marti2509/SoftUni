function solve() {
    let textToTransform = document.getElementById('text').value;
    let transformTo = document.getElementById('naming-convention').value;
    let resultBox = document.getElementById('result');

    let result = '';
    
    if (transformTo !== 'Camel Case' && transformTo !== 'Pascal Case') {
      resultBox.textContent = 'Error!'
    } else if (transformTo === 'Pascal Case') {
      let stringPascal = textToTransform.toLowerCase().split(' ');

      for (let i = 0; i < stringPascal.length; i++) {
        result += stringPascal[i][0].toUpperCase() + stringPascal[i].slice(1);
      }

      resultBox.textContent = result;
    } else {
      let stringCamel = textToTransform.toLowerCase().split(' ');
  
      for (let i = 0; i < stringCamel.length; i++) {
        if (i === 0) {
          result += stringCamel[i];
        } else {
          result += stringCamel[i][0].toUpperCase() + stringCamel[i].slice(1);
        }
      }
  
        resultBox.textContent = result;
    }
}