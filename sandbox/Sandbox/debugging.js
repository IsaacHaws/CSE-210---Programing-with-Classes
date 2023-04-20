const PI = 3.14;
let area = 0;
function circleArea(radius) {
  const area = radius * radius * PI;
  return area
}
area = circleArea(3);
console.log(area);

console.log("Changed the definition of pi and changed radius to a let variable")