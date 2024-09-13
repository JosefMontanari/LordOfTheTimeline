import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("the modal is open", () => {
  cy.get(".player-modal-content").should("be.visible");
});

When("I type {string} in the username field", (username) => {
  cy.get("input").type(username);
});

When("I choose an avatar", () => {
  cy.get('[src="/Legolas-avatar.png"]').click();
});

When("I click save the save button", () => {
  cy.get(".save-btn").click();
});

Then("I should see {string} on the game page", (username) => {
  cy.get(".Avatar-container > p > span").should("contain", username);
});
