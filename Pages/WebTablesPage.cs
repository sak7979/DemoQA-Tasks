//using Microsoft.Playwright;
//using static Microsoft.Playwright.Assertions;
//using System.Threading.Tasks;
//namespace demosite.Pages
//{
//    public class WebTablePage
//    {
//        private readonly IPage page;
//        public WebTablePage(IPage page)
//        {
//            this.page = page;
//        }
//        public async Task Navigate()
//        {
//            await page.GotoAsync("https://demoqa.com/webtables");

//        }
//        public async Task Addrecord(string firstName, string lastName, string userName,int age, int salary, string department)
//        {
//            await page.Locator("#addNewRecordButton").ClickAsync();
//            await page.Locator("#firstName").FillAsync(firstName);
//            await page.Locator("#lastName").FillAsync(lastName);
//            await page.Locator("#userEmail").FillAsync(userName);
//            await page.Locator("#age").FillAsync($"{age}");
//            await page.Locator("#salary").FillAsync($"{salary}");
//            await page.Locator("#department").FillAsync(department);
//            await page.Locator("#submit").ClickAsync();
//        }
//        public async Task SearchRecord(string Searchname)
//        {
//            await page.Locator("#searchBox").FillAsync(Searchname);
//            await Expect(page.Locator("tbody tr td").Nth(0)).ToContainTextAsync(Searchname);
//        }
//        public async Task ClearSearch()
//        {
//             await page.Locator("#searchBox").ClearAsync();
//        }
//        public async Task Editrecord(string firstname, string UpdatefirstName, string UpdatelastName, string UpdateuserName,int Updateage, int Updatesalary, string Updatedepartment)
//        {
//            await page.Locator("tbody tr").Filter(new() { HasTextString = firstname })
//              .Locator("[title='Edit']").ClickAsync();
//            await page.Locator("#firstName").FillAsync(UpdatefirstName);
//            await page.Locator("#lastName").FillAsync(UpdatelastName);
//            await page.Locator("#userEmail").FillAsync(UpdateuserName);
//            await page.Locator("#age").FillAsync($"{Updateage}");
//            await page.Locator("#salary").FillAsync($"{Updatesalary}");
//            await page.Locator("#department").FillAsync(Updatedepartment);
//            await page.Locator("#submit").ClickAsync();
//        }
//        public async Task Deleterecord(string firstName)
//        {
//            var targetRow = page.Locator("tbody tr").Filter(new() { HasText = firstName });
//            await targetRow.Locator("[title='Delete']").ClickAsync();
//        }
//        public async Task ValidDelte(string firstName)
//        {
//          var row = page.Locator("tbody tr").Filter(new()
//         {
//             HasTextString = firstName
//         });
//         await Expect(row).Not.ToBeVisibleAsync();
//        }
//    }
//}