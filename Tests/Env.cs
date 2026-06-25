using Reqnroll;
using demosite.Base;
using demosite.Utils;

namespace demosite.Tests
{
    [Binding]
    public class Env : Baseclass
    {
        public async Task NavigateToPage(string pageName)
        {
            string url = ConfigHelper.GetUrl(pageName);

            await page.GotoAsync(url);
        }
    }
}