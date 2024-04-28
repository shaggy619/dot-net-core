function animateProgressBar(circularProgress, progressValue, progressEndValue) {
    let progressStartValue = 0;
    let speed = 10;

    let progress = setInterval(() => {
        progressStartValue++;
        progressValue.textContent = `${progressStartValue}%`;
        circularProgress.style.background = `conic-gradient(#6b4ce6 ${progressStartValue * 3.6}deg, #ededed 0deg)`;

        if (progressStartValue === progressEndValue) {
            clearInterval(progress);
        }
    }, speed);
}

// Select all progress bars
let progressBars = document.querySelectorAll(".progress-bar-circular");

// Loop through each progress bar and animate
progressBars.forEach((progressBar, index) => {
    let circularProgress = progressBar.querySelector(".circular-progress");
    let progressValue = progressBar.querySelector(".progress-value");
    let progressEndValue;

    // Set different end values for each progress bar (adjust as needed)
    switch (index) {
        case 0:
            progressEndValue = 85;
            break;
        case 1:
            progressEndValue = 75;
            break;
        case 2:
            progressEndValue = 70;
            break;
        case 3:
            progressEndValue = 90;
            break;
        case 4:
            progressEndValue = 80;
            break;
        case 5:
            progressEndValue = 80;
            break;
        default:
            progressEndValue = 0;
    }

    animateProgressBar(circularProgress, progressValue, progressEndValue);
});