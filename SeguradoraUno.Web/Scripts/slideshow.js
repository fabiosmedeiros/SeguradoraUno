let contadorSlide = 0;

showSlides();

function showSlides() {
    let i;
    let slides = document.getElementsByClassName("slides-carrosel");
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    contadorSlide++;
    if (contadorSlide > slides.length) { contadorSlide = 1 }
    slides[contadorSlide - 1].style.display = "block";
    setTimeout(showSlides, 2000);
}
