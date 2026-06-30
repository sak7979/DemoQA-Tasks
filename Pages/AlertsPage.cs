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
        var tcs = new TaskCompletionSource<bool>();

        EventHandler<IDialog>? handler = null;

        handler = async (_, dialog) =>
        {
            await dialog.AcceptAsync();
            page.Dialog -= handler;

            tcs.SetResult(true);
        };

        page.Dialog += handler;

        await page.Locator("#timerAlertButton").ClickAsync();

        await tcs.Task; // Wait until dialog is actually handled
    }


    public async Task ConfirmAlert()
    {
        EventHandler<IDialog>? handler = null;

        handler = async (_, dialog) =>
        {
            await dialog.AcceptAsync();
            page.Dialog -= handler;
        };

        page.Dialog += handler;

        await page.Locator("#confirmButton").ClickAsync();
    }

    public async Task DismissConfirmAlert()
    {
        EventHandler<IDialog>? handler = null;

        handler = async (_, dialog) =>
        {
            await dialog.DismissAsync();
            page.Dialog -= handler;
        };

        page.Dialog += handler;

        await page.Locator("#confirmButton").ClickAsync();
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

