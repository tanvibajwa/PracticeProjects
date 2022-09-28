describe("test within, find, get functions", () => {

    it("test find and get and chainers", () => {
        cy.visit("https://www.brocksolutions.com/")
        cy.get("ul#menu-transportation-logistics-1 li").should("have.length", 3)
        cy.get("ul#menu-transportation-logistics-1 li")
        .find("a[href*='smartsuite']")
        .should("have.length", 1)
    })

    it("perform search using within", () => {
        cy.get("div#et-top-navigation").within(() => {
            cy.get("span#et_search_icon").click({force: true})
        })
        cy.get("form[role='search'] > input[name='s']").click().type("QA Software Engineer")
    })
})