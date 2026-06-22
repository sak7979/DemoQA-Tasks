using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using System.Threading.Tasks;
using System.IO;
namespace demosite.Pages
{
    public class Filespages
    {
        private readonly IPage page;
        public Filespages(IPage page)
        {
            this.page = page;
        }
        //public async Task Navigate()
        //{
        //await page.GotoAsync("https://demoqa.com/upload-download");
        //}
        public async Task UploadFile(string filepath)
        {
            await page.SetInputFilesAsync("#uploadFile", filepath);
        }
        public async Task ValidateFileupload(string uploadfilename)
        {
            string expected= await page.Locator("#uploadedFilePath").TextContentAsync();
            Console.WriteLine(expected);
            await Expect(page.Locator("#uploadedFilePath")).ToContainTextAsync(expected);
        }
        public async Task Downloadfile(string savepath)
        {
            var downloadTask = page.WaitForDownloadAsync();
            await page.Locator("#downloadButton").ClickAsync();
            var download = await downloadTask;
            string filelocation = Path.Combine(savepath, download.SuggestedFilename);
            await download.SaveAsAsync(filelocation);
        }
        public async Task ValidateDowload(string savepath, string filename)
        {
            string filelocation = Path.Combine(savepath, filename);
            Assert.IsTrue(File.Exists(filelocation),"Dowloaded");
        }
    }
}