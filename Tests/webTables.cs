using demosite.Base;
using demosite.Pages;
using NUnit.Framework;
using Reqnroll;
using System.Threading.Tasks;

namespace demosite.StepDefinitions
{
    [Binding]
    public class WebTableSteps : Baseclass
    {
        private WebTablePage web = null!;
        private string updatedName = null!; // to track updated name


        //[Given("user navigate to {string} page")]
        //public async Task WhenINavigate(string pagename)
        //{
        //    var pages = UrlMap.Url[pagename];
        //    await page.GotoAsync(pages);
        //}


        [When("user adds a new record")]
        public async Task AddRecords(Table table)
        {
            web = new WebTablePage(page);
            foreach (var row in table.Rows)
            {
                await web.Addrecord(
                    row["firstName"],
                    row["lastName"],
                    row["userName"],
                    int.Parse(row["age"]),
                    int.Parse(row["salary"]),
                    row["department"]
                );
            }
        }

        [Then("user searches for \"(.*)\"")]
        public async Task Search(string name)
        {
            await web.SearchRecord(name);
        }

        [When("user updates the record")]
        public async Task UpdateRecord(Table table)
        {
            var row = table.Rows[0];

            // Hardcoded old name (since not passed in feature)
            string oldName = "Lionel";

            updatedName = row["UpdatefirstName"];

            await web.Editrecord(
                oldName,
                row["UpdatefirstName"],
                row["UpdatelastName"],
                row["UpdateuserName"],
                int.Parse(row["Updateage"]),
                int.Parse(row["Updatesalary"]),
                row["Updatedepartment"]);
            await web.ClearSearch();
        }

        [Then("user deletes the record \"(.*)\"")]
        public async Task Delete(string name)
        {
            await web.Deleterecord(name);
        }

        [Then("the record \"(.*)\" should not be visible")]
        public async Task ValidateDelete(string name)
        {
            await web.ValidDelte(name);
        }
    }
}
