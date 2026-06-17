using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System.Threading.Tasks;
namespace demosite.Pages
{
    public class Resize
    {
        private readonly IPage page;
        private float beforeWidth;
        private float beforeHeight;
        public Resize(IPage page)
        {
            this.page = page;
        }
        public async Task Navigate()
        {
            await page.GotoAsync("https://demoqa.com/resizable");
        }
        public async Task ResizeTab()
        {
            var box = page.Locator("#resizableBoxWithRestriction");
            var handle = page.Locator("#resizableBoxWithRestriction .react-resizable-handle");
            var before = await box.BoundingBoxAsync();
            if (before != null)
            {
                beforeWidth = before.Width;
                beforeHeight = before.Height;

                await page.Mouse.MoveAsync(
                    before.X + before.Width - 5,
                    before.Y + before.Height - 5
                );
                await page.Mouse.DownAsync(); 
                await page.Mouse.MoveAsync(
                    before.X + before.Width + 100,
                    before.Y + before.Height + 50
                );
                await page.Mouse.UpAsync();
            }
        }
        public async Task<bool> ValidateResize()
        {
            var after = await page.Locator("#resizableBoxWithRestriction").BoundingBoxAsync();
            if (after == null) return false;
            return after.Width > beforeWidth && after.Height > beforeHeight;
        }
    }
}