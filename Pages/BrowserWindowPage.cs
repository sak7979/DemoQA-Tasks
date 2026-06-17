using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System.Threading.Tasks;
using Reqnroll;
namespace demosite.Pages;
public class BroweserWindow
{
    private readonly IPage page;
    private readonly IBrowserContext context;
      private IPage newTab = null!; 
        public BroweserWindow(IPage page, IBrowserContext context)
    {
        this.page = page;
        this.context = context;
    }
    public async Task Navigate()
    {
        await page.GotoAsync("https://demoqa.com/browser-windows");
    }
    public async Task Newtab()
    {
        var newPageTask = context.WaitForPageAsync();
        await page.Locator("#tabButton").ClickAsync();
        newTab = await newPageTask;
        await newTab.WaitForLoadStateAsync();      
    }
    public async Task ValidateTab()
    {
        // var newPageTask = context.WaitForPageAsync();
        // var newTab = await newPageTask;
        await Expect(newTab.Locator("#sampleHeading")).ToHaveTextAsync("This is a sample page");
        await page.BringToFrontAsync();
    }
   
}