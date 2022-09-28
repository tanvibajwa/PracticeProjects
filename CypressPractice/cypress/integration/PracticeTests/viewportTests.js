describe("testing different view port", ()=>{

    before(() => {
        console.log('I run before something')
    })

    beforeEach(() => {
        console.log('I run before every test in every spec file')
        cy.visit("http://www.google.com")
    })

    it("open in 550, 750",() => {
        cy.viewport(550,750)
        cy.screenshot()
        cy.wait(200)
    })
    
    it("open in macbook 13",() => {
        cy.viewport('macbook-13')
        cy.screenshot()
        cy.wait(200)
    })

    it("open in iphone-x",() => {
        cy.viewport('iphone-x')
        cy.screenshot()
        cy.wait(200)
        var a = 10;
        var s = new String();
    })

})