const canvas = document.getElementById("canvasId");
const g = canvas.getContext("2d");

g.beginPath();
g.rect(100, 100, 200, 200);
g.stroke();

g.beginPath();
g.arc(200, 200, 30, 0, Math.PI *2);
g.fillStyle = "blue";
g.fillStyle();
