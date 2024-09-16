import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("I am on the home page", () => {
  cy.visit("/");
});

// Given('No modal is open', () => {
//   // TODO: implement step
// });

When("I click the How To Play button", () => {
  cy.get(":nth-child(2) > .navbar-link").click();
});

Then("How to play modal should open", () => {
  cy.get(".modal-content").should("exist");
});

// Given("I am on the home page", () => {
//   cy.visit("/");
// });

When("I click the High Score button", () => {
  cy.get(":nth-child(3) > .navbar-link").click();
});

Then("High Score modal should open", () => {
  cy.get(".highscore-modal-content").should("exist");
});
