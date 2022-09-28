describe("checkbox test", () => {

    it("check all checkboxes", () =>{

        cy.visit("https://oldnavy.gapcanada.ca/")
        cy.get(".sitewide-1qosac6").click()
        cy.get(".divisionLink").first().trigger("mouseover")
        
    
    })
})