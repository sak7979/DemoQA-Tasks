using Microsoft.Playwright;
using NUnit.Framework;
using Reqnroll;
using System.Threading.Tasks;
//[assembly: Parallelizable(ParallelScope.Fixtures)]
//[assembly: LevelOfParallelism(3)]
namespace demosite.Base{
    public abstract class Baseclass
    {
        protected static IPlaywright playwright=null!;
        protected static IBrowser browser = null!;
        protected  static IBrowserContext context = null!;
        protected  static IPage page = null!;
        [BeforeScenario]
        public async Task Setup()
        {

            if (page != null && !page.IsClosed)
            {
                Console.WriteLine("setup already done");
                return;
            }
            playwright = await Playwright.CreateAsync();

        browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 800
            });
            context = await browser.NewContextAsync();
            page = await context.NewPageAsync();
        
        }
        [AfterScenario]
        public async Task TearDown()
        {
            //if (page != null) await page.CloseAsync();
            if (context != null) await context.CloseAsync();
            //if (browser != null) await browser.CloseAsync();
            
        //playwright?.Dispose();

        }
    }
}
