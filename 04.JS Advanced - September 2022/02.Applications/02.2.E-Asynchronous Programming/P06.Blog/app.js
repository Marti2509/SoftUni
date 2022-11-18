async function attachEvents() {
    let btnLoadPostsElement = document.getElementById("btnLoadPosts");
    btnLoadPostsElement.addEventListener("click", onClickPostBtn);
    let btnViewPostElement = document.getElementById("btnViewPost");
    btnViewPostElement.addEventListener("click", onClickViewBtn);
    let postsElement = document.getElementById("posts");

    const postsUrl = "http://localhost:3030/jsonstore/blog/posts";
    const commentsUrl = "http://localhost:3030/jsonstore/blog/comments";

    async function onClickPostBtn() {
        postsElement.innerHTML = "";

        let response = await fetch(postsUrl);
        let data = await response.json();
    
        for (const post in data) {
            // data[post] => Object
    
            let option = document.createElement("option");
            option.value = post;
            option.textContent = data[post].title;

            postsElement.appendChild(option);
        }
    }

    async function onClickViewBtn() {
        let postTitleElement = document.getElementById("post-title");
        let postBodyElement = document.getElementById("post-body");
        let postCommentsElement = document.getElementById("post-comments");
        let value = postsElement.value;
        
        postCommentsElement.innerHTML = "";

        let post = {};
        let comments = [];
        
        let counter = 0;

        let postsResponse = await fetch(postsUrl);
        let postsData = await postsResponse.json();

        for (const currPost in postsData) {
            if (currPost === value) {
                post = postsData[currPost];
                postTitleElement.textContent = post.title;
                postBodyElement.textContent = post.body;
            }
        }

        let commentsResponse = await fetch(commentsUrl);
        let commentsData = await commentsResponse.json();

        for (const comment in commentsData) {
            if (value === commentsData[comment].postId) {
                comments[counter++] = commentsData[comment];
            }
        }
        
        for (const comment of comments) {
            let li = document.createElement("li");
            li.textContent = comment.text;

            postCommentsElement.appendChild(li);
        }
    }
}



attachEvents();