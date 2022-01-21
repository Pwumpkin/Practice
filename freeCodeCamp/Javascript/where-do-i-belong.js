function getIndexToIns(arr, num) {
  let arr2 = arr.sort(function(a, b){return a - b});

  for(let i = 0; i < arr2.length; i++){
    if(arr[i] >= num) return i;
  }
  
  return arr.length;
}

