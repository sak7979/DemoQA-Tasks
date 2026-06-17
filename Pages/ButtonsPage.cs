using Microsoft.Playwright;
using NUnit.Framework; 
using static Microsoft.Playwright.Assertions;
using System.Threading.Tasks;
using Reqnroll;
using demosite.Utils;

public class ButtonsPage
{
    private readonly IPage page;

    public ButtonsPage(IPage page)
    {
        this.page = page;
    }

    //public async Task Navigate()
    //{
    //    await page.GotoAsync(Urls.Buttons);
    //}

    public async Task ClickGenericButtonAsync(string buttonName)
    {
        string normalizedName = buttonName.Replace(" ", "").ToLower();

        switch (normalizedName)
        {
            case string s when s.Contains("doubleclick"):
                await page.GetByRole(AriaRole.Button, new() { Name = "Double Click Me", Exact = true })
                          .DblClickAsync();
                break;

            case string s when s.Contains("rightclick"):
                await page.GetByRole(AriaRole.Button, new() { Name = "Right Click Me", Exact = true })
                          .ClickAsync(new LocatorClickOptions { Button = MouseButton.Right });
                break;

            case "clickme":
                await page.GetByRole(AriaRole.Button, new() { Name = "Click Me", Exact = true })
                          .ClickAsync();
                break;           
            default:
                await page.GetByRole(AriaRole.Button, new() { Name = buttonName, Exact = true })
                          .ClickAsync();
                break;
        }
    } 
    public async Task Validation(string doubleClickMsg, string Right, string Click)
    {
        await Expect(page.Locator("#doubleClickMessage")).ToContainTextAsync(doubleClickMsg);
        await Expect(page.Locator("#rightClickMessage")).ToContainTextAsync(Right);
        await Expect(page.Locator("#dynamicClickMessage")).ToContainTextAsync(Click);
    }
}
