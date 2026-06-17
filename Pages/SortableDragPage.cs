using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System.Threading.Tasks;
namespace demosite.Pages
{
    public class SortableDrag
    {
        private readonly IPage page;
        public SortableDrag(IPage page)
        {
            this.page = page;
        }
        public async Task Navigate()
        {
            await page.GotoAsync("https://demoqa.com/sortable");
        }
        public async Task ReorderItems()
        {
            var source = page.Locator("#demo-tabpane-list .list-group-item").Filter(new() { HasText = "One" });
            var dest = page.Locator("#demo-tabpane-list .list-group-item").Filter(new() { HasText = "Five" });

            await source.ScrollIntoViewIfNeededAsync();

            var sourceBox = await source.BoundingBoxAsync();
            var destBox = await dest.BoundingBoxAsync();

            if (sourceBox != null && destBox != null)
            {
                // 1. Move to the exact center of item "One"
                await page.Mouse.MoveAsync(sourceBox.X + (sourceBox.Width / 2), sourceBox.Y + (sourceBox.Height / 2));

                // 2. Press down and hold the left mouse button
                await page.Mouse.DownAsync();

                //Add a small 200ms delay to let the React DOM register the mousedown event
                await page.WaitForTimeoutAsync(200);
                //Drag downwards towards item "Five"
                //Increase the vertical offset (+40 instead of +15) to guarantee it passes the item threshold
                await page.Mouse.MoveAsync(
                    destBox.X + (destBox.Width / 2),
                    destBox.Y + (destBox.Height / 2) + 40,
                    new() { Steps = 20 } // Increased steps for a smoother movement trail
                );

                //Add another brief pause before releasing so the placeholder registers the drop index
                await page.WaitForTimeoutAsync(200);

                // 4. Release the mouse button to complete the sorting drop
                await page.Mouse.UpAsync();

                await page.WaitForTimeoutAsync(1000);
            }
        }

    }
}