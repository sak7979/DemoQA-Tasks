using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System.Threading.Tasks;
using NUnit.Framework;
namespace demosite.Pages
{
    public class RadioButtonpage
    {
        private readonly IPage page;
        public RadioButtonpage(IPage page)
        {
            this.page = page;
        }
        public async Task Navigate()
        {
            await page.GotoAsync("https://demoqa.com/radio-button");
        }
        public async Task SelectYes()
        {
            await page.Locator("label[for='yesRadio']").CheckAsync();

        }
        public async Task Impressive()
        {
            await page.Locator("label[for='impressiveRadio']").CheckAsync();
        }
        public async Task NOVerifyDisabled()
        {
            await page.Locator("#noRadio").IsDisabledAsync();
           // Assert.IsTrue(isDisabled, "No radio button should be disabled");
        }
        public async Task ValidateResponse(string expected)
        {
            await Expect(page.Locator(".text-success"))
                .ToHaveTextAsync(expected);
        }
  
    }
}


