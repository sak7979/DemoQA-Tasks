@smoke
Feature: Resize page
@ResizePage
Scenario: Resize the tab
    Given user navigates to "Resizable" page
    When user resizes the box
    Then the box should increase