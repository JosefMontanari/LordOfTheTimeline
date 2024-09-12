Feature: Navigation

    Scenario: Go to singleplayer game
        Given I am on the homepage
        When I click the singleplayer button
        Then I should be on the singleplayer game page

    Scenario: Go to multiplayer game
        Given I am on the homepage
        When I click the multiplayer button
        Then I should be on the multiplayer game page

    Scenario: Go to home page
        Given I am on the game page
        And No modal is open
        When I click the Home button
        Then I should be on the home page