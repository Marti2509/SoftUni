window.addEventListener("load", solve);

function solve() {
  let formBtn = document.getElementById('form-btn');
  formBtn.addEventListener('click', createStory);

  let previewBox = document.getElementById('preview-list');

  let firstName = document.getElementById('first-name');
  let lastName = document.getElementById('last-name');
  let age = document.getElementById('age');
  let storyTitle = document.getElementById('story-title');
  let genre = document.getElementById('genre');
  let story = document.getElementById('story');

  let list = [];

  function createStory() {
    let firstNameValue = firstName.value;
    let lastNameValue = lastName.value;
    let ageValue = age.value;
    let storyTitleValue = storyTitle.value;
    let genreValue = genre.value;
    let storyValue = story.value;

    list.push(firstNameValue);
    list.push(lastNameValue);
    list.push(ageValue);
    list.push(storyTitleValue);
    list.push(genreValue);
    list.push(storyValue);

    firstName.value = '';
    lastName.value = '';
    age.value = '';
    storyTitle.value = '';
    story.value = '';

    if (!firstNameValue || !lastNameValue || !ageValue || !storyTitleValue || !genreValue || !storyValue) {
      return;
    }

    createStoryForList(firstNameValue, lastNameValue, ageValue, storyTitleValue, genreValue, storyValue);

    formBtn.setAttribute('disabled', true);
  }

  function createStoryForList(firstNameValue, lastNameValue, ageValue, storyTitleValue, genreValue, storyValue) {
    let li = document.createElement('li');
    li.classList.add('story-info');

    let article = document.createElement('article');
    
    let h4 = document.createElement('h4');
    h4.textContent = `Name: ${firstNameValue} ${lastNameValue}`;

    let p1 = document.createElement('p');
    p1.textContent = `Age: ${ageValue}`;

    let p2 = document.createElement('p');
    p2.textContent = `Title: ${storyTitleValue}`;

    let p3 = document.createElement('p');
    p3.textContent = `Genre: ${genreValue}`;
  
    let p4 = document.createElement('p');
    p4.textContent = storyValue;

    let saveBtn = document.createElement('button');
    saveBtn.classList.add('save-btn');
    saveBtn.addEventListener('click', saveStory);
    saveBtn.textContent = 'Save Story';

    let editBtn = document.createElement('button');
    editBtn.classList.add('edit-btn');
    editBtn.addEventListener('click', editStory);
    editBtn.textContent = 'Edit Story';

    let deleteBtn = document.createElement('button');
    deleteBtn.classList.add('delete-btn');
    deleteBtn.addEventListener('click', deleteStory);
    deleteBtn.textContent = 'Delete Story';
    
    li.appendChild(article);

    article.appendChild(h4);
    article.appendChild(p1);
    article.appendChild(p2);
    article.appendChild(p3);
    article.appendChild(p4);

    li.appendChild(saveBtn);
    li.appendChild(editBtn);
    li.appendChild(deleteBtn);

    previewBox.appendChild(li);
  }

  function editStory(e) {
    e.target.parentElement.remove();

    firstName.value = list[0];
    lastName.value = list[1];
    age.value = list[2];
    storyTitle.value = list[3];
    genre.value = list[4];
    story.value = list[5];

    formBtn.disabled = false;
  }

  function deleteStory(e) {
    e.target.parentElement.remove();

    formBtn.disabled = false;
  }

  function saveStory(e) {
    console.log(e.target.parentElement.parentElement.parentElement.parentElement.remove());

    let h1 = document.createElement('h1');
    h1.textContent = 'Your scary story is saved!';

    let body = document.getElementsByClassName('body')[0];
    body.appendChild(h1);
  }
}
