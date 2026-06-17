using demosite.Base;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System.Threading.Tasks;
namespace demosite.Utils;
public class Button : Baseclass 
{

    public static Dictionary<string, string> buttons = new()
        {
            {"Username","#userName" },
            {"Useremail","#userEmail"},
            {"CurrentAddress","#currentAddress"},
            {"PermanentAddress","#permanentAddress"},
            {"Submit", "#submit"},
            {"Doubleclick","#doubleClickBtn"},
            {"RightClick","#rightClickBtn"},
            {"ClickMe","#HQ9Tx" }
        };
    public async Task ClickButtonAsync(string buttonName)
    {
        await page.GetByRole(AriaRole.Button, new() { Name = buttonName, Exact = true })
                .ClickAsync();
    }

}







