using Microsoft.Playwright;
using NUnit.Framework;
using Reqnroll;
//[assembly: Parallelizable(ParallelScope.Fixtures)]
//[assembly: LevelOfParallelism(3)]

namespace demosite.Base
{
    public abstract class Baseclass
    {
        private static readonly object _logLock = new();
        protected static IPlaywright playwright = null!;
        protected static IBrowser browser = null!;
        protected static IBrowserContext context = null!;
        protected static IPage page = null!;

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

            context = await browser.NewContextAsync(
                new BrowserNewContextOptions
                {
                    RecordVideoDir = "Videos"
                });

            page = await context.NewPageAsync();

            await context.Tracing.StartAsync(
                new TracingStartOptions
                {
                    Screenshots = true,
                    Snapshots = true,
                    Sources = true
                });

            Directory.CreateDirectory("Logs");

            page.Console += (_, msg) =>
            {
                lock (_logLock)
                {
                    File.AppendAllText(
                        @"Logs\ConsoleLogs.txt",
                        $"{DateTime.Now} | {msg.Type} | {msg.Text}{Environment.NewLine}");
                }

            };
        }

        [AfterScenario]
        public async Task TearDown()
        {
            try
            {
                if (context != null)
                    await context.Tracing.StopAsync();
            }
            catch
            {
            }

            if (context != null)
                await context.CloseAsync();

            if (browser != null)
                await browser.CloseAsync();

            playwright?.Dispose();

            page = null!;
            context = null!;
            browser = null!;
        }
    }
}























//using Microsoft.Playwright;
//using NUnit.Framework;
//using Reqnroll;
////[assembly: Parallelizable(ParallelScope.Fixtures)]
////[assembly: LevelOfParallelism(3)]

//namespace demosite.Base
//{
//    public abstract class Baseclass
//    {
//        protected static IPlaywright playwright = null!;
//        protected static IBrowser browser = null!;
//        protected static IBrowserContext context = null!;
//        protected static IPage page = null!;

//        [BeforeScenario]
//        public async Task Setup()
//        {
//            if (page != null)
//            {
//                try
//                {
//                    if (!page.IsClosed)
//                    {
//                        Console.WriteLine("setup already done");
//                        return;
//                    }
//                }
//                catch
//                {
//                    // page belongs to a disposed context
//                }
//            }

//            playwright = await Playwright.CreateAsync();

//            browser = await playwright.Chromium.LaunchAsync(
//                new BrowserTypeLaunchOptions
//                {
//                    Headless = false,
//                    SlowMo = 800
//                });

//            context = await browser.NewContextAsync(
//                new BrowserNewContextOptions
//                {
//                    RecordVideoDir = "Videos"
//                });

//            page = await context.NewPageAsync();
//        }

//        [AfterScenario]
//        public async Task TearDown()
//        {
//            if (context != null)
//            {
//                await context.CloseAsync();
//            }

//            page = null!;
//            context = null!;
//        }
//    }
//}























//using Microsoft.Playwright;
//using NUnit.Framework;
//using Reqnroll;
//using System.Threading.Tasks;
////[assembly: Parallelizable(ParallelScope.Fixtures)]
////[assembly: LevelOfParallelism(3)]
//namespace demosite.Base
//{
//    public abstract class Baseclass
//    {
//        protected static IPlaywright playwright = null!;
//        protected static IBrowser browser = null!;
//        protected static IBrowserContext context = null!;
//        protected static IPage page = null!;
//        [BeforeScenario]
//        public async Task Setup()
//        {

//            if (page != null && !page.IsClosed)
//            {
//                Console.WriteLine("setup already done");
//                return;
//            }
//            playwright = await Playwright.CreateAsync();

//            browser = await playwright.Chromium.LaunchAsync(
//                new BrowserTypeLaunchOptions
//                {
//                    Headless = false,
//                    SlowMo = 800
//                });
//            context = await browser.NewContextAsync();
//            page = await context.NewPageAsync();

//        }
//        [AfterScenario]
//        public async Task TearDown()
//        {
//            //if (page != null) await page.CloseAsync();
//            if (context != null) await context.CloseAsync();
//            //if (browser != null) await browser.CloseAsync();

//            //playwright?.Dispose();

//        }
//    }
//}
