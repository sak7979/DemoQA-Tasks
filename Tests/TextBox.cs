// using Microsoft.Playwright;
// using demosite.Pages;
// //using Allure.Reqnroll;
// //using Allure.Net.Commons;
// using Fields;
// using demosite.Base; // Imports Baseclass
// using Reqnroll;
// using System.Threading.Tasks;

// namespace demosite.Tests;

// [Binding]
// public class TaskTextBox : Baseclass // Inherits from your Baseclass
// {
//     private Textbox _textbox;

//     //[Given("user Navigates to textbox page")]
//     //public async Task TextBoxTest()
//     //{
//     //    // Instantiates your page object using the protected 'page' from Baseclass
//     //    _textbox = new Textbox(page);
//     //    await _textbox.Navigate();
//     //}

//     [When(@"I enter ""(.*)"" as ""(.*)""")]
//     public async Task WhenIEnterFieldAsValue(string fieldName, string value)
//     {
//         _textbox = new Textbox(page);
//         var loc = FieldMappings.TextBoxFields[fieldName];
//         await _textbox.EnterValue(loc, value);
//     }

//     //[When("click on submit button")]
//     //public async Task Click()
//     //{
//     //    _textbox = new Textbox(page);
//     //    await _textbox.Submit();
//     //}

//     [Then(@"I should see field ""(.*)"" as ""(.*)""")]
//     public async Task ThenIShouldSeeFieldAsValue(string fieldName, string expectedValue)
//     {
//         _textbox = new Textbox(page);
//         await _textbox.ValidateValue(fieldName, expectedValue);
//     }
//     //public async Task Submit()
//     //{
//     //    _textbox = new Textbox(page);
//     //    await _textbox.Submit();
//     //}
        
// }
