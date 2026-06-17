using demosite.Base; // Imports Baseclass
using demosite.Pages;
using NUnit.Framework;
using Reqnroll;
using System.Threading.Tasks;
using Microsoft.Playwright;
using System.Linq;

namespace demosite.Steps;

[Binding]
public class ButtonsSteps : Baseclass // Inherits from your Baseclass
{
    private ButtonsPage _buttonsPage;

    //[Given(@"user navigates to buttons page")]
    //public async Task GivenUserNavigatesToButtonsPage()
    //{
    //    _buttonsPage = new ButtonsPage(page); // Uses inherited 'page'
    //    await _buttonsPage.Navigate();
    //}

    [When(@"I click ""(.*)"" button")]
    public async Task WhenIClickButton(string buttonName)
    {
        _buttonsPage = new ButtonsPage(page);
        await _buttonsPage.ClickGenericButtonAsync(buttonName);
    }

    [Then(@"I should all button messages")]
    public async Task ThenIShouldSeeButtonMessages()
    {
        _buttonsPage = new ButtonsPage(page);
        await _buttonsPage.Validation(
                "You have done a double click",
                "You have done a right click",
                "You have done a dynamic click"
        );
    }
}
