using Microsoft.Playwright;
namespace demosite.Utils
{
    public static class RetryHelper
    {
        public static async Task ExecuteAsync(
            Func<Task> action,
            int retryCount = 3)
        {
            Exception? lastException = null;

            for (int i = 0; i < retryCount; i++)
            {
                try
                {
                    await action();
                    return;
                }
                catch (Exception ex)
                {
                    lastException = ex;
                    await Task.Delay(1000);
                }
            }

            throw lastException!;
        }
    }
}