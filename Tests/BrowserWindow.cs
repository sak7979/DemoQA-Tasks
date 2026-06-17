using Microsoft.Playwright;
using NUnit;
using Reqnroll;
using demosite.Pages;
using demosite.Base;
[Binding]
public class TaskBrowserWindow : Baseclass
{
    private BroweserWindow Brow;
    [Given("user navigates to browser windows page")]
    public async Task BrowserNavigate()
    {
        Brow =new BroweserWindow(page,context);
        await Brow .Navigate();
    }
    [When("user clicks on new tab button")]
    public async Task NewTab()
    {
        await Brow .Newtab();
    }
    [Then("new tab should display sample heading")]
    public async Task Validate()
    {
    
        await Brow.ValidateTab();
        
    }
}