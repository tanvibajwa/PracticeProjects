describe("dropdown test", () => {

    it.skip("dropdown select test", () => {
        cy.visit("https://www.amazon.ca/")
        cy.get("#searchDropdownBox").select("Amazon Devices", {force:true})
        .should("have.value","search-alias=amazon-devices")
    })

    it("google search result test", () => {
        cy.visit("https://www.google.com/")
        cy.get("[name='q']").type("cypress")
        cy.get(".erkvQe")
        .find("li span")
        .contains("cypress tree") //if a span has cypress tree, then click on it
        .click({force: true})
    })
})