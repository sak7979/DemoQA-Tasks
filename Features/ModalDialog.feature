@smoke
Feature: Modal Dialog 
@Modals
Scenario Outline: Handling Modal dialogs in browser
    Given user navigates to "ModalDialogs" page
    When user clicks on showsmallmodal dialog pops up
    Then small modal should be displayed and closed
    When user clicks on showLargeModal dialog pops up
    Then large modal content should be displayed