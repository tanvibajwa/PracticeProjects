describe("handling error if a page returns a non 2XX response", () => {

    it("hubspot login test", () => {
        cy.visit("https://hubspot.com/login",{failOnStatusCode: false})
       // cy.wait(5000)
        cy.get("#username").type("abc@abc.com")
        cy.get("input#password").type("abc_abc.com")
        cy.get("button#loginBtn").click()
    })

} )