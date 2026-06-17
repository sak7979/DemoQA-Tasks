using NUnit.Framework;
using demosite.Base;
using Reqnroll;
using demosite.Pages;
using demosite.Utils;
using System.Threading.Tasks;
public class Envi : Baseclass
{
    [Given("user navigates to {string} page")]
    public async Task Navigate(string pageName)
    {
        string env = Environment.GetEnvironmentVariable("TEST_ENV") ?? "QA";

        string url = EnvHelper.GetUrl(env, pageName.ToLower());

        await page.GotoAsync(url);
    }
}
