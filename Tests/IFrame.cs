using Reqnroll;
using demosite.Base;
using demosite.Pages;

namespace demosite.Tests
{
    [Binding]
    public class FramesTest : Baseclass
    {
        private Framespage frames = null;
        private NestedFramesPage nested = null;

        [Given("user navigates to frames page")]
        public async Task NavigateFrames()
        {
            frames = new Framespage(page);

            await frames.Navigate();
        }

        [When("user validates frame1 and frame2")]
        public async Task ValidateFrames()
        {
            await frames.Frames1();
        }

        [Then("both frames should display sample text")]
        public async Task ValidateText()
        {
            // Validation already handled in Frames1()
        }

        [Given("user navigates to nested frames page")]
        public async Task NavigateNestedFrames()
        {
            nested = new NestedFramesPage(page);

            await nested.Navigate();
        }

        [When("user validates nested frames")]
        public async Task ValidateNested()
        {
            await nested.ValidateNestedFrames();
        }

        [Then("parent and child frames should be displayed correctly")]
        public async Task ValidateNestedText()
        {
            // Validation already done in page method
        }
    }
}