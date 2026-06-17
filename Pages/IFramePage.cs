using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System.Threading.Tasks;
namespace demosite.Pages
{
    public class Framespage
    {
        private readonly IPage page;
        public Framespage(IPage page)
        {
            this.page = page;
        }
        public async Task Navigate()
        {
            await page.GotoAsync("https://demoqa.com/frames");
        }
        public async Task Frames1()
        {
            var frame1 = page.FrameLocator("#frame1");
            await Expect(frame1.Locator("#sampleHeading")).ToHaveTextAsync("This is a sample page");
            var frame2 = page.FrameLocator("#frame2");
            await Expect(frame2.Locator("#sampleHeading")).ToHaveTextAsync("This is a sample page");
        }
    }
}