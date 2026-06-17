using NUnit.Framework;
using Microsoft.Playwright;
using Reqnroll;
using demosite.Base;
using demosite.Pages;
using System.Threading.Tasks;
using System.ComponentModel;
namespace demosite.Tests
{
    [Binding]
    public class RadioButtonTest : Baseclass
    {
        private RadioButtonpage? radio;
        [Test]
        [Given("user navigates to the radio-button page")]
        public async Task RadioButton()
        {
            radio = new RadioButtonpage(page);
            await radio.Navigate();
        }
        [When("user selects yesRadio")]
        public async Task Yes(){
            await radio.SelectYes();
        }
        [Then("Validate response with {string}")]
        public async Task ValidateYes(string expected){
            await radio.ValidateResponse(expected);
        }
        [When("user selects impressiveRadio")]
        public async Task Impressive(){
            await radio.Impressive();
        }
        // [Then ("Validate response with {string}")]
        // public async Task ValidateImpressive(string expected){
        //     await radio.ValidateResponse(expected);
        // }
        [When("user tries to select noRadio it is disabled")]
        public async Task Noverify(){
            await radio.NOVerifyDisabled();
        }
    }
}