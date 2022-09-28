
var assert = require('assert')
describe('Math functions', function(){
    it('add', function(){
        var a = 10;
        var b = 20;
        var c = a+b;
        assert.equal(c,30);
    });
    it('sub', function(){
        var a = 10;
        var b = 20;
        var c = a-b;
        assert.equal(c,-10);

    });
    it('mul', function(){
        var a = 10;
        var b = 20;
        var c = a*b;
        assert.equal(c,200);

    });
})