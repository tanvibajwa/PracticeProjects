/// <reference types = "cypress"/>

//const { Assertion } = require("chai");

it('should be able to add a new todo to the list', () =>{
    cy.visit('http://todomvc-app-for-testing.surge.sh/')
    cy.get('.new-todo').type("fold laundry{enter}")
    cy.get('label').should("have.text", "fold laundry");
    cy.get('.toggle').click();
   // cy.get('label').should('have.css', 'text-decoration-line', 'line-through')
    // cy.get('.clear-completed').click();
    
})
