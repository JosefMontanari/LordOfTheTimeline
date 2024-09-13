import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("I am on the homepage", () => {
  cy.visit("/");
});

When("I click the singleplayer button", () => {
  cy.get(":nth-child(1) > .play-button > p").click();
});

Then("I should be on the singleplayer game page", () => {
  cy.url().should("include", "/game");
});

/* No duplicate steps, this one already above
Given('I am on the homepage', () => {});*/

When("I click the multiplayer button", () => {
  cy.get(":nth-child(2) > .play-button > p").click();
});

Then("I should be on the multiplayer game page", () => {
  cy.url().should("include", "/multiplayer");
});

Given("I am on the game page", () => {
  cy.visit("/game");
});

Given("No modal is open", () => {
  cy.get(".player-modal-overlay").click("topLeft");
});

When("I click the Home button", () => {
  cy.get("a > .navbar-link").click();
});

Then("I should be on the home page", () => {
  cy.get(".home-page > .lotr-font").should("exist");
});
