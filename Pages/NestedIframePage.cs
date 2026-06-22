
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System.Threading.Tasks;
using NUnit.Framework;

namespace demosite.Pages
{
    public class NestedFramesPage
    {
        private readonly IPage page;

        public NestedFramesPage(IPage page)
        {
            this.page = page;
        }
        //public async Task Navigate()
        //{
        //    await page.GotoAsync("https://demoqa.com/nestedframes");
        //}
        public async Task ValidateNestedFrames()
        {
            var ParentFrame = page.FrameLocator("#frame1");
            await Expect(ParentFrame.Locator("body")).ToContainTextAsync("Parent frame");
            var ChildFrame = ParentFrame.FrameLocator("iframe");
            await Expect(ChildFrame.Locator("body")).ToContainTextAsync("Child Iframe");
        }
    }
}