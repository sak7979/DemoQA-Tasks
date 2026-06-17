@smoke
Feature: Generic Button Framework
@ButtonPage
Scenario: Verify all button click actions using generic handler
    Given user navigates to "Buttons" page
    When I click "doubleclick" button 
    When I click "rightclick" button
    When I click "clickme" button
    Then I should all button messages