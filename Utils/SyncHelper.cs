using Microsoft.Playwright;

namespace demosite.Utils
{
    public static class SyncHelper
    {
        public static async Task ClickWhenReady(
            IPage page,
            string selector)
        {
            await WaitHelper.WaitForVisible(page, selector);

            await page.Locator(selector).ClickAsync();
        }

        public static async Task FillWhenReady(
            IPage page,
            string selector,
            string value)
        {
            await WaitHelper.WaitForVisible(page, selector);

            await page.Locator(selector).FillAsync(value);
        }
    }
}