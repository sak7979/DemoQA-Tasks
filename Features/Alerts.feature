@smoke
Feature: AlertsFunctionality

@alert
Scenario: Handle immediate alert
    Given user navigates to "Alerts" page
    When user clicks on immediate alert button
    Then immediate alert should be accepted

@alert   
Scenario: Handle Time alert
    Given user navigates to "Alert" page
    When user clicks on time alert button
    Then time alert should be accepted

@alert
Scenario: Accept confirm alert
    Given user navigates to "Alerts" page
    When user clicks on Confirm alert button and accepts alert
    Then Confirm alert should show text "You selected Ok"
@alert
Scenario: Dismiss confirm alert
    Given user navigates to "Alerts" page
    When user clicks on Confirm alert button and dismisses alert
    Then Confirm alert should show text "You selected Cancel"

@alert
Scenario Outline: Handle Prompt dialog
    Given user navigates to "Alerts" page
    When user enters "<name>" in Prompt alert
    Then prompt result should contain entered "<name>"

Examples:
| name       |
| Playwright |
