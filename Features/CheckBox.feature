Feature: Checkbox 
@Checkbox
Scenario Outline: Handling the Checkbox
Given user navigates to the Checkbox page
When user clicks Plus icon near Home Checkbox
And user selects Desktop Checkbox
And user selects Documents Checkbox
And user selects Downloads Checkbox
But user unselects Downloads Checkbox
Then selected Checkbox should be validated 