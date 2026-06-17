@smoke
Feature: Resize page
@ResizePage
Scenario: Resize the tab
    Given user navigates to resizable page
    When user resizes the box
    Then the box should increase