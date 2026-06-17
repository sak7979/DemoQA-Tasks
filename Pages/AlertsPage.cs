using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System.Threading.Tasks;
using Reqnroll;
namespace demosite.Pages;
public class AlertPage
{
    private readonly IPage page;
    public AlertPage(IPage page)
    {
        this.page = page;
    }
    public async Task Navigate()
    {
        await page.GotoAsync("https://demoqa.com/alerts");
    }
  
public async Task ImmediateAlert()
{
     EventHandler<IDialog>? handler = null;
           handler = async (_, dialog) =>
           {
               await dialog.AcceptAsync();
               page.Dialog -= handler;
           };
           page.Dialog += handler;
        await page.Locator("#alertButton").ClickAsync();
}

    public async Task TimeAlert()
    {
        EventHandler<IDialog>? handler = null;
        handler = async (_, dialog) =>
        {
            await dialog.AcceptAsync();
            page.Dialog -= handler;
        };
        page.Dialog += handler;
        await page.Locator("#timerAlertButton").ClickAsync();

    }
    public async Task ConfirmAlert()
    {
        EventHandler<IDialog>? handler = null;
        handler =  async (_, dial) =>
        {
            await dial.AcceptAsync();
            page.Dialog -= handler;
        };
        page.Dialog += handler;
        await page.Locator("#confirmButton").ClickAsync();
        string result = await page.Locator("#confirmButton").TextContentAsync();
        if (result.Contains("OK"))
        {
            await Expect(page.Locator("#confirmResult"))
            .ToContainTextAsync("You selected Ok");

        }
        else if (result.Contains("Cancel"))
        {
            await Expect(page.Locator("#confirmResult"))
            .ToContainTextAsync("You selected Cancel");

        }
    }
    public async Task PromptDialog(string text)
    {
        page.Dialog += async (_,dial) =>
        {
            await dial.AcceptAsync(text);
        };
        await page.Locator("#promtButton").ClickAsync();
        await Expect(page.Locator("#promptResult")).ToContainTextAsync(text);
    }
}


/*
public async Task ImmediateAlert()
{
    var dialogTask = page.WaitForDialogAsync();
    await page.Locator("#alertButton").ClickAsync();
    var dialog = await dialogTask;
    await dialog.AcceptAsync();
}*/

