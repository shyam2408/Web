
document.addEventListener("DOMContentLoaded", () => {
    const images = document.querySelectorAll<HTMLImageElement>(".slides img");
    let currentIndex = 0;

    function showImage(index: number): void {
        images.forEach((img, i) => {
            img.classList.toggle("active", i === index);
        });
    }

    document.querySelector<HTMLButtonElement>(".prev")!.addEventListener("click", () => {
        currentIndex = (currentIndex - 1 + images.length) % images.length;
        showImage(currentIndex);
    });

    document.querySelector<HTMLButtonElement>(".next")!.addEventListener("click", () => {
        currentIndex = (currentIndex + 1) % images.length;
        showImage(currentIndex);
    });
});
