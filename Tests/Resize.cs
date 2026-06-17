using NUnit.Framework;
using demosite.Base;
using demosite.Pages;
using Reqnroll;
using System.Threading.Tasks;
namespace demosite.Tests
{
    [Binding]
    public class ResizableTest : Baseclass
    {
        private readonly Resize resize;
        public ResizableTest()
        {
            resize = new Resize(page);
        }
        [Test]
        [Given("user navigates to resizable page")]
        public async Task Navigation()
        {
            await resize.Navigate();
        }
        [When("user resizes the box")]
        public async Task Resizetab(){
            await resize.ResizeTab();
        }
        [Then("the box should increase")]
        public async Task ValidateResize(){
            await resize.ValidateResize();
        }
    }
}
