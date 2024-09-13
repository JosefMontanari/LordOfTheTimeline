 Feature: Modal
 
  Scenario: Open How To Play Modal
        Given I am on the home page
        When I click the How To Play button
        Then How to play modal should open


        Scenario: Open High Score Modal
        Given I am on the home page
        When I click the High Score button
        Then High Score modal should open


        Scenario: Open How To Play Modal in Singleplayer
        Given I am on the game page
        And No modal is open
        When I click the How To Play button
        Then How to play modal should open