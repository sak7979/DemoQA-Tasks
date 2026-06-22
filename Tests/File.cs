using NUnit.Framework;
using demosite.Base;
using Reqnroll;
using demosite.Pages;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
namespace demosite.Tests
{
    [Binding]
    public class Fileupldowl : Baseclass
    {
        private Filespages pageobj = null!;
        //string filepath = @"C:\Users\sakethram.n\OneDrive - TECHNOVERT SOLUTIONS PRIVATE LIMITED\Desktop\Filssss\HIII.txt";
        //string downloadpath = @"C:\Users\sakethram.n\OneDrive - TECHNOVERT SOLUTIONS PRIVATE LIMITED\Desktop\Filssss";
        //[Test]
        //[Given("user navigates to Files upload-download page")]
        //public async Task Navigate()
        //{
        //    pageobj = new Filespages(page);
        //    string filepath = @"C:\Users\sakethram.n\OneDrive - TECHNOVERT SOLUTIONS PRIVATE LIMITED\Desktop\Filssss\HIII.txt";
        //    string downloadpath = @"C:\Users\sakethram.n\OneDrive - TECHNOVERT SOLUTIONS PRIVATE LIMITED\Desktop\Filssss";
        //    await pageobj.Navigate();
        //}
        [When(@"user uploads Files using filepath ""(.*)""")]
        public async Task Upload(string filepath){
            pageobj = new Filespages(page);
            await pageobj.UploadFile(filepath);
        }
        [Then(@"Validate the Upload Files using filename ""(.*)""")]
        public async Task ValidateUpload(string file){
            await pageobj.ValidateFileupload(file);
        }
        [When(@"user downloads file to ""(.*)""")]
        public async Task Dowload(string downloadpath){
            await pageobj.Downloadfile(downloadpath);
        }
        [Then(@"Validate downloaded file in ""(.*)"" with filename ""(.*)""")]
        public async Task ValidateDownload(string downloadpath, string filename){
            await pageobj.ValidateDowload(downloadpath, filename);
        }
    }
}