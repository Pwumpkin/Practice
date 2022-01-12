const s = [5, 7, 2];
function editInPlace() {
  // Only change code below this line

  const temporary = s[s.length -1];
  s.pop(s.length - 1);
  s.unshift(temporary);

  // Only change code above this line
}
editInPlace();
