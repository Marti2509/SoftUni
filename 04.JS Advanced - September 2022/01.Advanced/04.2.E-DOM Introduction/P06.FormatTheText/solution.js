function solve() {
  document.getElementById('output').innerHTML = '';
  let input = document.getElementById('input').value;
  let arrText = input.split('.').filter(e => e.length > 0);

  for (let i = 0; i < arrText.length; i += 3) {
    let res = [];

    for (let j = 0; j < 3; j++) {
      if (arrText[i + j]) {
        res.push(arrText[i + j]);
      }
    }

    let resText = res.join('. ') + '.'.trim();
    document.getElementById('output').innerHTML += `<p>${resText}</p>`
  }
}