// Smooth Slider


const menuLinks = document.querySelectorAll('.sidebar-menu a');
const allSections = document.querySelectorAll('.Main-Content > div');

menuLinks.forEach(link => {
    link.addEventListener('click', function (e) {
        e.preventDefault();
        const targetId = this.getAttribute('href').substring(1);

        // Hide all sections
        allSections.forEach(section => {
            section.classList.remove('active');
        });

        // Show target section
        const targetSection = document.getElementById(targetId);
        if (targetSection) {
            targetSection.classList.add('active');
        }
    });
});


// Search Post Comment User 

const CommentInput = document.getElementById("Comment-Search");
const comments = document.querySelectorAll(".comment-card");

const PostInput = document.getElementById("Post-Search");
const posts = document.querySelectorAll(".custom-post");

const AllUserInput = document.getElementById("All-User-Search");
const users = document.querySelectorAll(".user-card");

// Comments Search
CommentInput.addEventListener("input", () => {
    const searchValue = CommentInput.value.toLowerCase();

    comments.forEach(comment => {
        const text = comment.textContent.toLowerCase();
        comment.style.display = text.includes(searchValue) ? "block" : "none";
    });
});

// Posts Search
PostInput.addEventListener("input", () => {
    const searchValue = PostInput.value.toLowerCase();

    posts.forEach(post => {
        const text = post.textContent.toLowerCase();
        post.style.display = text.includes(searchValue) ? "block" : "none";
    });
});

// Users Search
AllUserInput.addEventListener("input", () => {
    const searchValue = AllUserInput.value.toLowerCase();

    users.forEach(user => {
        const text = user.textContent.toLowerCase();
        user.style.display = text.includes(searchValue) ? "block" : "none";
    });
});

