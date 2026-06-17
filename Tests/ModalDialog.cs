    using NUnit.Framework;
    using demosite.Base;
    using demosite.Pages;
    using Reqnroll;
    using System.Threading.Tasks;
    namespace demosite.Tests
    {
        [Binding]
        public class ModalTest: Baseclass
        {
            private ModalPage modal;
            [Test]
            [Given("user navigates to modal-dialogs page")]
            public async Task Navigation()
            {
                modal = new ModalPage(page);
                await modal.Naviagate();
            }
            [When("user clicks on showsmallmodal dialog pops up")]
            public async Task smallmodal()
            {
                await modal.SmallModal();
            }
            [Then("small modal should be displayed and closed")]
            public async Task vlaidationsmall()
            {
                //Already validated in SmallModal
            }
            [When("user clicks on showLargeModal dialog pops up")]
             public async Task LargeModal(){
                await modal.LargeModal();
            }
            [Then("large modal content should be displayed")]
            public async Task ValidationLarge()
            {
                //Already validated in LargeModal
            }
        }
    }