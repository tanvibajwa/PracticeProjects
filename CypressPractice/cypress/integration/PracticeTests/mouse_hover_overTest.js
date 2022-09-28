//Trigegr function to do a mouse over on 1 element and child element will be visible and there are 3 such levels of parent and child menu.
// not a dropdown list.

describe("mouse hover over feature", () => {

    it.skip("click on Sign up link test", () => {

        cy.visit("https://www.spicejet.com/")
        cy.get("#ctl00_HyperLinkLogin").trigger("mouseover")
        cy.contains("SpiceClub Members").trigger("mouseover")
        cy.contains("Sign up").click()
    })

    it.skip("click on Member login link test", () => {

        cy.go("back")
        cy.get("#ctl00_HyperLinkLogin").trigger("mouseover")
        cy.contains("SpiceClub Members").trigger("mouseover")
        cy.contains("Member Login").click({force: true})
    })

    
    it("add to cart test", () => {

        cy.visit("http://automationpractice.com/index.php")
        cy.get(".ajax_add_to_cart_button").first().click()
        cy.get(".cross").click({force: true})
        cy.wait(3000);
        cy.get(".cart_block").should("be.hidden").invoke("show")
        cy.get("#button_order_cart").click()
        cy.get(".cart_navigation").contains("Proceed to checkout")
    })
})