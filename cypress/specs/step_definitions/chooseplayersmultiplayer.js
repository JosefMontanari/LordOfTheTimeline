import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("I am on the multiplayer page", () => {
  cy.visit("http://localhost:5173/multiplayer");
});

Given("I can see the modal for choosing amount of players", () => {
  cy.get(".player-modal-content").should("be.visible");
});

When("I select {string} players", (a) => {
  cy.get(".player-count-dropdown").select(a.toString());
});

When("I click the Save button for choosing players", () => {
  cy.get(".save-btn").click();
});

Then("I should see the modal for choosing name and avatar", () => {
  cy.get(".player-modal-content").should("be.visible");
});

Given("I can see the choosing player modal", () => {
  cy.get(".player-modal-content").should("be.visible");
});

Given("I see the input field for choosing name", () => {
  cy.get("input").should("be.visible");
});

Given("I see the avatars", () => {
  cy.get(".avatar-selection").should("be.visible");
});

When("I write Calle in the input field", () => {
  cy.get("input").type("Calle");
});

When("I choose the Gollum avatar", () => {
  cy.get('[src="/Gollum-avatar.png"]').click();
});

When("I click the Save button for player 1", () => {
  cy.get(".save-btn").click();
});

When("I write Otto in the input field", () => {
  cy.get("input").type("Otto");
});

When("I choose the Frodo avatar", () => {
  cy.get('[src="/Frodo-avatar.png"]').click();
});

When("I click the Save button for player 2", () => {
  cy.get(".save-btn").click();
});

When("I write Gustav in the input field", () => {
  cy.get("input").type("Gustav");
});

When("I choose the Orc avatar", () => {
  cy.get('[src="/Orc-avatar.png"]').click();
});

When("I click the Save button for player 3", () => {
  cy.get(".save-btn").click();
});

Then(
  "I should see the usernames and avatars beneath the timeline to the left",
  () => {
    cy.get(".multiplayer-avatars-container > :nth-child(1)").should(
      "be.visible"
    );
  }
);
