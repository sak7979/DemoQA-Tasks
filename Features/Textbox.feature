@smoke
Feature: Generic Input Step Framework
  @Textbox
  Scenario Outline: Verify text box form submission using generic fields
    Given user navigates to "TextBox" page
    When I enter "name" as "<name>"
    And I enter "email" as "<email>"
    And I enter "currentaddress" as "<currentAddress>"
    And I enter "permanentaddress" as "<permanentAddress>"
    And click on submit button

      Examples:

<<<<<<< HEAD
      | name  | email                | currentAddress | permanentAddress |
      | John  | john@test.com        | Hyderabad      | India            |
      | Jonhn | johnsnow@test.com    | Hyderabad      | India            |
=======
      | name  | email                 | currentAddress | permanentAddress |
      | John  | john@test.com         | Hyderabad      | India            |
      | Jonhn | johnsnow@test.com     | Hyderabad      | India            |
>>>>>>> 44923ca143bf62f24c57dd45e98aced47eab572f
