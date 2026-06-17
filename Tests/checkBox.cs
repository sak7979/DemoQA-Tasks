using Reqnroll;
using demosite.Base;
using demosite.Pages;
using Microsoft.Playwright;

namespace demosite.Tests
{
    [Binding]
    public class Task2checkboxTest : Baseclass
    {
        private CheckBoxPage checkBox;
        [Given("user navigates to the Checkbox page")]
        public async Task Navigate()
        {
            checkBox = new CheckBoxPage(page);
            await checkBox.Navigate();
        }

        [When("user clicks Plus icon near Home Checkbox")]
        public async Task HomeIcon()
        {
            await checkBox.ExpandIT();
        }

        [When("user selects Desktop Checkbox")]
        public async Task Desktopcheck()
        {
            await checkBox.SelectDesktop();
        }

        [When("user selects Documents Checkbox")]
        public async Task DocumentCheck()
        {
            await checkBox.SelectDocument();
        }

        [When("user selects Downloads Checkbox")]
        public async Task Dowloadcheck()
        {
            await checkBox.SelectDownload();
        }

        [When("user unselects Downloads Checkbox")]
        public async Task Unselectdowload()
        {
            await checkBox.UnselectDowload();
        }

        [Then("selected Checkbox should be validated")]
        public async Task ValidateCheck()
        {
            await checkBox.Validation();
        }
    }
}