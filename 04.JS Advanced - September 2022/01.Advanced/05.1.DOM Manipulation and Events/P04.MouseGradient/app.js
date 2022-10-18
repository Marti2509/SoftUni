function attachGradientEvents() {
    let div = document.getElementById('result');
    let gradient = document.getElementById('gradient');

    gradient.addEventListener('mousemove', function(event) {
        div.textContent = Math.floor(event.offsetX / 3) + '%';
    });
}