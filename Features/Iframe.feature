@smoke
Feature: Frames Functionality

  @Frames
  Scenario: Validate normal frames

    Given user navigates to "Frames" page
    When user validates frame1 and frame2
    Then both frames should display sample text


  @NestedFrames
  Scenario: Validate nested frames

    Given user navigates to "NestedFrames" page
    When user validates nested frames
    Then parent and child frames should be displayed correctly