function confirmEnding(str, target) {
  for(let i = 0; i < target.length; i++) {
    let temp = str.slice(str.length -1 -i);
    if (temp === target) {
      return true;
    }
  }
  return false;
}

confirmEnding("Bastian", "n");