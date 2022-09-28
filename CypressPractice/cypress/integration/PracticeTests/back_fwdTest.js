describe("back and forward simulation on browser", () => {

    it("back forward test", () =>{
        cy.visit("https://www.brocksolutions.com/")
        // cy.get("div#et-top-navigation")
        // .find("a[href*='careers']")
        // .click()
        cy.get("ul#top-menu > .menu-item.menu-item-47416.menu-item-object-custom.menu-item-type-custom.rb-nav-underline > a")
        .click()
        cy.go("back")
        cy.wait(2000)
        cy.go("forward")
    })
})