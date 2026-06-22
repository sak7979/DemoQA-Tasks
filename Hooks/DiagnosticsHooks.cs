using demosite.Base;
using Reqnroll;

namespace demosite.Hooks
{
    [Binding]
    public class DiagnosticsHooks : Baseclass
    {
        [AfterScenario(Order = 1)]
        public async Task CaptureFailure(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError != null)
            {
                Directory.CreateDirectory("Screenshots");
                Directory.CreateDirectory("Traces");

                string scenarioName =
                    scenarioContext.ScenarioInfo.Title.Replace(" ", "_");

                await page.ScreenshotAsync(new()
                {
                    Path = $"Screenshots/{scenarioName}.png",
                    FullPage = true
                });

                try
                {
                    await context.Tracing.StopAsync(new()
                    {
                        Path = $"Traces/{scenarioName}.zip"
                    });
                }
                catch
                {
                    // Ignore trace errors
                }
            }
        }
    }
}