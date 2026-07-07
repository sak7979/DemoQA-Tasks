using Reqnroll;
using demosite.Base;
using demosite.Pages;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using Urlsss;
using Fields;
[Binding]
public class Common : Baseclass
{
    [Given("user navigates to {string} page")]
    public async Task WhenINavigate(string pagename)
    {
        //string url = EnvHelper.GetUrl(env, pageName.ToLower());
        //await page.GotoAsync(url);
        var pages = UrlMap.Url[pagename];
        await page.GotoAsync(pages);
    }
    [When("User enters {string} as {string}")]
    public async Task FieldAsValue(string fieldname, string value)
    {
        // FIX: Changed from fieldName to fieldname to match your method parameter variable name casing exactly
        string normalizedKey = fieldname.Replace(" ", "").ToLower();

        var selector = FieldMappings.TextBoxFields[normalizedKey];
        await page.Locator(selector).FillAsync(value);
    }
    // ADD THESE TWO METHODS TO YOUR COMMON.CS FILE AND DELETE TASKTEXTBOX.CS ENTIRELY
    [When("click on submit button")]
    public async Task Submit()
    {
        // Reuses your generic Task 3 ARIA role button strategy directly via the inherited page object
        await page.GetByRole(AriaRole.Button, new() { Name = "Submit", Exact = true }).ClickAsync();
    }

    [Then(@"I should see field {string} as {string}")]
    public async Task ThenIShouldSeeFieldAsValue(string fieldName, string expectedValue)
    {
        //string normalizedKey = fieldName.Replace(" ", "").ToLower();
        var selector = FieldMappings.TextBoxFields[fieldName];

        // Asserts the UI values using the global page context
        await Expect(page.Locator(selector)).ToHaveValueAsync(expectedValue);
    }

}