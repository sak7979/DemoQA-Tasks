
using Gherkin.Ast;
using Microsoft.Playwright;
using System;
using System.Threading.Tasks;

namespace utils
{
    public static class TestHelper
    {
        public static async Task SafeStep(string stepName, Func<Task> action, IPage page)
        {
            try
            {
                await action();
            }
            catch(Exception ex)
            {
             string safeName = stepName.Replace(" ","_");
             string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
             string folder = "Screenshots";
             if (!Directory.Exists(folder))
             {
                Directory.CreateDirectory(folder);
             }

             string screenshotPath = $"{folder}/failed_{safeName}_{timestamp}.png";
             await page.ScreenshotAsync(new PageScreenshotOptions
                {
                    Path = screenshotPath, 
                    FullPage = true 
                });   
                throw;
            }
        }
    }
}


