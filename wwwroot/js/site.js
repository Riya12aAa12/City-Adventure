// Write your Javascript code.
// Initialize Swiper
var swiper = new Swiper('.swiper-container', {
    autoplay: {
        delay: 5000, // Delay between slides in milliseconds
        disableOnInteraction: false, // Autoplay still works when user interacts with swiper
    },
    loop: true, // Loop through slides
    pagination: {
        el: '.swiper-pagination', // Pagination container
        clickable: true, // Allow pagination bullets to be clicked
    },
});

