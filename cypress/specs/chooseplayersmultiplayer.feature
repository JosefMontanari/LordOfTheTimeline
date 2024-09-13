Feature: Choose Players Multiplayer

    Scenario: Select amount of players
        Given I am on the multiplayer page
        And I can see the modal for choosing amount of players
        When I select "3" players
        And I click the Save button for choosing players
        Then I should see the modal for choosing name and avatar

    Scenario: Choose players
        Given I can see the choosing player modal
        And I see the input field for choosing name
        And I see the avatars
        When I write Calle in the input field
        And I choose the Gollum avatar
        And I click the Save button for player 1
        And I write Otto in the input field 
        And I choose the Frodo avatar
        And I click the Save button for player 2
        And I write Gustav in the input field 
        And I choose the Orc avatar
        And I click the Save button for player 3
        Then I should see the usernames and avatars beneath the timeline to the left

    
        