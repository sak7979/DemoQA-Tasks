@smoke
Feature: Radio Button
@Radio
Scenario: Handling Radio Button
    Given user navigates to the radio-button page
    When user selects yesRadio
    Then Validate response with "Yes"
    When user selects impressiveRadio
    Then Validate response with "Impressive"
    When user tries to select noRadio it is disabled