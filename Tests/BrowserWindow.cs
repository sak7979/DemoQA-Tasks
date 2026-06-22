using Microsoft.Playwright;
using NUnit;
using Reqnroll;
using demosite.Pages;
using demosite.Base;
[Binding]
public class TaskBrowserWindow : Baseclass
{
    private BroweserWindow Brow;

    [When("user clicks on new tab button")]
    public async Task NewTab()
    {
        Brow = new BroweserWindow(page, context);
        await Brow.Newtab();
    }
    // Missing closing brace here
    [Then("new tab should display sample heading")]
    public async Task Validate()
    {
        await Brow.ValidateTab();
    }
}