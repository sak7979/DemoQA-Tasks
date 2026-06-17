using Microsoft.Playwright;
using NUnit;
using Reqnroll;
using static Microsoft.Playwright.Assertions;
using demosite.Pages;
using demosite.Base;
[Binding]
public class AlertTask:Baseclass
{
    private AlertPage alert;
    //[Given("user navigates to {string} page")]
    //public async Task AlertNavigate()
    //{
    //    alert = new AlertPage(page);
    //    await alert.Navigate();
    //}
    [When("user clicks on immediate alert button")]
    public async Task AlertImmediate(){
        alert = new AlertPage(page);
        await alert.ImmediateAlert();
    }
    [Then("time alert should be accepted")]
    [When("user clicks on time alert button")]
    public async Task AlertTime()
    {
        alert = new AlertPage(page);
        await alert.TimeAlert();
    }
    [When("user clicks on Confirm alert button")]
    public async Task ConfirmAlert(){
        alert = new AlertPage(page);
        await alert.ConfirmAlert();
    }
    [Then("Confirm alert should show text {string}")]
    public async Task ValidateConfirmAlert(string expectedText)
    {
        await Expect(page.Locator("#confirmResult"))
        .ToContainTextAsync(expectedText);
    }

    [When(@"user enters ""(.*)"" in Prompt alert")]
    public async Task PromptAlert(string name ){
        alert = new AlertPage(page);
        await alert.PromptDialog(name);
    }
    [Then(@"prompt result should contain entered ""(.*)""")]
    public async Task ValidatePromptAlert(string expectedText)
    {
        await Expect(page.Locator("#promptResult"))
        .ToContainTextAsync(expectedText);
    }

}