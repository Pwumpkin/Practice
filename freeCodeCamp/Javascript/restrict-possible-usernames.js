let username = "JackOfAllTrades";

//let userCheck1 = /^[^\d^_0-9\W]{2,}[0-9]*$/i;
//let userCheck2 = /^[^\d^_0-9\W]{1,}[0-9]{2,}$/i;

//let result = (userCheck.test(userCheck1) || userCheck.test(userCheck2));

let userCheck = /(^[^\d^_0-9\W]{2,}[0-9]*$)|(^[^\d^_0-9\W]{1,}[0-9]{2,}$)/;
let result = userCheck.test(username);