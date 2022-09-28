describe('sample test', ()=>{
    it('check a link on website', ()=>{
        cy.visit('https://www.freshworks.com/')
        cy.contains('Customers').click()
        cy.url().should("include", '/customers')
    })
})