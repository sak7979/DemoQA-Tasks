@smoke
Feature: Handling MultipleBrowsers
@browsers
Scenario Outline: Handle Multiple Browsers
    Given user navigates to browser windows page
    When user clicks on new tab button
    Then new tab should display sample heading 