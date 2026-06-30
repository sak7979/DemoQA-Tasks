giusing Microsoft.Playwright;
using Reqnroll;
using static Microsoft.Playwright.Assertions;
using demosite.Pages;
using demosite.Base;

[Binding]
public class AlertTask : Baseclass
{
    private AlertPage alert = null!;

    [When("user clicks on immediate alert button")]
    public async Task AlertImmediate()
    {
        alert = new AlertPage(page);
        await alert.ImmediateAlert();
    }

    [Then("immediate alert should be accepted")]
    public void ImmediateAlertShouldBeAccepted()
    {
        // Alert already handled
    }

    [When("user clicks on time alert button")]
    public async Task AlertTime()
    {
        alert = new AlertPage(page);
        await alert.TimeAlert();
    }

    [Then("time alert should be accepted")]
    public void TimeAlertShouldBeAccepted()
    {
        // Alert already handled
    }

    [When("user clicks on Confirm alert button and accepts alert")]
    public async Task ConfirmAlert()
    {
        alert = new AlertPage(page);
        await alert.ConfirmAlert();
    }

    [When("user clicks on Confirm alert button and dismisses alert")]
    public async Task DismissConfirmAlert()
    {
        alert = new AlertPage(page);
        await alert.DismissConfirmAlert();
    }

    [Then("Confirm alert should show text {string}")]
    public async Task ValidateConfirmAlert(string expectedText)
    {
        await Expect(page.Locator("#confirmResult"))
            .ToContainTextAsync(expectedText);
    }

    [When(@"user enters ""(.*)"" in Prompt alert")]
    public async Task PromptAlert(string name)
    {
        alert = new AlertPage(page);
        await alert.PromptDialog(name);
    }

    [Then(@"prompt result should contain entered ""(.*)""")]
    public async Task ValidatePromptAlert(string expectedText)
    {
        await Expect(page.Locator("#promptResult"))
            .ToContainTextAsync(expectedText);
        Console.WriteLine("Done");
    }
}