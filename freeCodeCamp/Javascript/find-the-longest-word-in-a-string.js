function findLongestWordLength(str) {
  const array = str.split(" ");
  let longest = "";
  for (let i = 0; i < array.length; i++) {
    if (array[i].length > longest.length) {
      longest = array[i];
    } 
  }
  return longest.length;
}

findLongestWordLength("The quick brown fox jumped over the lazy dog");