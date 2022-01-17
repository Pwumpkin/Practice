let sampleWord = "astronaut";

let pwRegex = /(?=\w{5,})(?=^\w*\d{2}\w*$)(?!\d{5})/ //; // Change this line
let result = pwRegex.test(sampleWord);