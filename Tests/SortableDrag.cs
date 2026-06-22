using NUnit.Framework;
using Microsoft.Playwright;
using Reqnroll;
using demosite.Base;
using demosite.Pages;
using System.Threading.Tasks;
namespace demosite.Tests
{
    [Binding]
    public class SortableDragDrop : Baseclass
    {
        private SortableDrag? sort;
        //[Test]
        //[Given("user navigates to sortable page")]
        //public async Task SortNavigate()
        //{
        //    sort = new SortableDrag(page);
        //    await sort.Navigate();
        //}
        [When("user drags item One and drops it near Five")]
        public async Task Reordering()
        {
            sort = new SortableDrag(page);
            await sort.ReorderItems();
        }
        [Then("the list should be reordered successfully")]
        public async Task Validate()
        {

            var items = await page.Locator("#demo-tabpane-list .list-group-item")
                            .AllInnerTextsAsync();
            Assert.AreNotEqual("One", items[0], "Item 'One' was not moved");
        }

                

    }
}