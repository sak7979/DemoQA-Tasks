using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System;
using NUnit.Framework;
using System.Formats.Asn1;
namespace demosite.Pages
{
    public class CheckBoxPage
    {
        private readonly IPage page;
        public CheckBoxPage(IPage page)
        {
            this.page = page;
        }
        public async Task Navigate()
        {
            await page.GotoAsync("https://demoqa.com/checkbox");
        }
        public async Task ExpandIT()
        {
            await page.Locator(".rc-tree-switcher_close").First.ClickAsync();
        }
        public async Task SelectDesktop()
        {
            await page.Locator("[aria-label='Select Desktop']").ClickAsync();
        }
        public async Task SelectDocument()
        {
            await page.Locator("[aria-label='Select Documents']").ClickAsync();
        }
        public async Task SelectDownload()
        {
            await page.Locator("[aria-label='Select Downloads']").ClickAsync();
        }
        public async Task UnselectDowload()
        {
            await page.Locator("[aria-label='Select Downloads']").ClickAsync();
        }
        public async Task Validation()
        {
            await Expect(page.Locator("#result")).ToContainTextAsync("desktop");
            await Expect(page.Locator("#result")).ToContainTextAsync("documents");
            await Expect(page.Locator("#result")).Not.ToContainTextAsync("downloads");

        }
    }
}   
