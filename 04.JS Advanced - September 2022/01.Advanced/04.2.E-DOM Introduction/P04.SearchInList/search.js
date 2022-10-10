function search() {
   let towns = Array.from(document.getElementById('towns').children);
   let searchText = document.getElementById('searchText').value;

   let matches = 0;
   
   for (const town of towns) {
      let townName = town.textContent;
      
      if (townName.includes(searchText)) {
         town.style.textDecoration = 'underline';
         town.style.fontWeight = 'bold';

         matches++;
      } else {
         town.style.textDecoration = '';
         town.style.fontWeight = '';
      }
   }

   document.getElementById('result').textContent = `${matches} matches found`;
}