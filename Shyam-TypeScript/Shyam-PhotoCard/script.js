document.addEventListener("DOMContentLoaded", function () {
    var images = document.querySelectorAll(".slides img");
    var currentIndex = 0;
    function showImage(index) {
        images.forEach(function (img, i) {
            img.classList.toggle("active", i === index);
        });
    }
    document.querySelector(".prev").addEventListener("click", function () {
        currentIndex = (currentIndex - 1 + images.length) % images.length;
        showImage(currentIndex);
    });
    document.querySelector(".next").addEventListener("click", function () {
        currentIndex = (currentIndex + 1) % images.length;
        showImage(currentIndex);
    });
});
