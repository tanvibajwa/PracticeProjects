
var assert = require('assert')
describe('Math functions', function(){
    it.only('add', function(){
        var a = 10;
        var b = 20;
        var c = a+b;
        assert.equal(c,30);
    });
    it.skip('sub', function(){
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

    it('div', function(){
        var a = 100;
        var b = 20;
        var c = a/b;
        assert.equal(c,5);

    });
})