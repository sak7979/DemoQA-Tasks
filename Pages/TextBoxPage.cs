using Microsoft.Playwright;
using System.Threading.Tasks;
using static Microsoft.Playwright.Assertions;
//using System.Collections.Generic;
using Fields;
namespace demosite.Pages;

public class Textbox
{
    private readonly IPage _page;

    public Textbox(IPage page)
    {
        _page = page;
    }

    //public async Task Navigate()
    //{
    //    await _page.GotoAsync(Urlsss.TextBox);
    //}
    public async Task EnterValue(string locator, string value)
    {
        await _page.Locator(locator).FillAsync(value);     
    }
    public async Task Submit()
    {
        await _page.GetByRole(AriaRole.Button, new() { Name = "Submit", Exact = true }).ClickAsync();
    }
    public async Task ValidateValue(string locator, string value)
    {
        await Expect(_page.Locator(locator)).ToHaveTextAsync(value);
    }

}
