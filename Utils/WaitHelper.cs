using Microsoft.Playwright;

namespace demosite.Utils
{
    public static class WaitHelper
    {
        public static async Task WaitForVisible(IPage page, string selector)
        {
            await page.Locator(selector).WaitForAsync(
                new LocatorWaitForOptions
                {
                    State = WaitForSelectorState.Visible
                });
        }

        public static async Task WaitForHidden(IPage page, string selector)
        {
            await page.Locator(selector).WaitForAsync(
                new LocatorWaitForOptions
                {
                    State = WaitForSelectorState.Hidden
                });
        }

        public static async Task WaitForPageLoad(IPage page)
        {
            await page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        }
    }
}