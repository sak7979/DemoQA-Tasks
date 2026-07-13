@smoke
@regression
Feature: Sortable Drag and Drop

  @Sortable
  Scenario: User reorders items in sortable list
    Given user navigates to "Sortable" page
    When user drags item One and drops it near Five
    Then the list should be reordered successfully
