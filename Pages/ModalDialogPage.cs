using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System.Threading.Tasks;
namespace demosite.Pages
{
    public class ModalPage
    {
        private readonly IPage page;
        public ModalPage(IPage page)
        {
            this.page = page;
        }
<<<<<<< HEAD
        //public async Task Naviagate()
        //{
        //    await page.GotoAsync("https://demoqa.com/modal-dialogs");
        //}
=======
        // public async Task Naviagate()
        // {
        //     await page.GotoAsync("https://demoqa.com/modal-dialogs");
        // }
>>>>>>> 44923ca143bf62f24c57dd45e98aced47eab572f
        public async Task SmallModal()
        {
            await page.Locator("#showSmallModal").ClickAsync();
            await Expect(page.Locator("//div[@class='modal-title h4']")).ToContainTextAsync("Small Modal");
            await page.Locator("#closeSmallModal").ClickAsync();
        }
        public async Task LargeModal()
        {
            await page.Locator("#showLargeModal").ClickAsync();
            await Expect(page.Locator("//div[@class='modal-content']")).ToBeVisibleAsync();
            await page.Locator("//div[@class='modal-body']").EvaluateAsync("el => el.scrollTop = el.scrollHeight");
            await page.Locator("#closeLargeModal").ClickAsync();
        }
    }
}
