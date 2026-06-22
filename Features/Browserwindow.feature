@smoke
Feature: Handling MultipleBrowsers
@browsers
Scenario Outline: Handle Multiple Browsers
    Given user navigates to "BrowserWindows" page
    When user clicks on new tab button
    Then new tab should display sample heading 