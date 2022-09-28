const chai = require('chai')
const expect = chai.expect;

// let a = 1, b =2;
// expect(a).to.be.equals(b, "a and b are not equal");

function randomObj(){
    return 3
    return "one"
    let obj1 = {
        a: 10,
        b: 'Hello'
    }
    return obj1;
}

let x = new randomObj(); 
y = new randomObj(); 
expect(x).to.be.equals(y)
// y.a = 3;

// expect(x.a).to.be.not.equals(y.a)