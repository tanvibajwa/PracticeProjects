describe("brock website", ()=>
{
    it('login test', ()=>
    {
        cy.visit("http://172.16.4.10/IMSS/")
        cy.contains("Production").click()
      //  cy.get(".amber.card-panel.lighten-4  .landingPageHeader").click()
        cy.url().should("include", "/LandingPage")
        cy.get("[onkeypress] td:nth-of-type(2) .InputTextBox").type('brock')
        cy.get("[onkeypress] td:nth-of-type(4) .InputTextBox").type(".Brockadmin86")
        cy.get("[type='submit']").click()
        cy.title().should("eq", "Key Performance Indicators")
        cy.get("[alt='SmartSort']").should("be.visible")
        .and("have.length", 1)
    })
})