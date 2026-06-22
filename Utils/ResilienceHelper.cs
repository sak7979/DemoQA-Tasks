using Microsoft.Playwright;

namespace demosite.Utils;

public static class ResilienceHelper
{
    public static async Task SafeClick(
        IPage page,
        string selector)
    {
        await RetryHelper.ExecuteAsync(async () =>
        {
            await SyncHelper.ClickWhenReady(page, selector);
        });
    }

    public static async Task SafeFill(
        IPage page,
        string selector,
        string value)
    {
        await RetryHelper.ExecuteAsync(async () =>
        {
            await SyncHelper.FillWhenReady(page, selector, value);
        });
    }
}