Feature: Avatar selection

  Scenario: Choose singleplayer avatar
    Given I am on the game page
    And the modal is open
    When I type "Gustav" in the username field
    And I choose an avatar
    And I click save the save button
    Then I should see "Gustav" on the game page