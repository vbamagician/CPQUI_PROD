using CPQUI.Controls;
using CPQUI.Drivers;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUICloudAccelerationStarterPackForAzureStepDefinitions
    {
        private readonly Driver _driver;
        private readonly CommonControls _commonControls;

        CPQUICloudAccelerationStarterPackForAzureStepDefinitions(Driver driver)
        {
            _driver = driver;
            _commonControls = new CommonControls(_driver.Page);
        }

        [Given(@"I click on Next button from definition page")]
        public async Task GivenIClickOnNextButtonFromDefinitionPage()
        {
            const string definitionPagePlacementText = "next-1";
            await _commonControls.ClickOnNextButtonPage(definitionPagePlacementText);
        }

        [Given(@"I click on Next button from scope page")]
        public async Task GivenIClickOnNextButtonFromScopePage()
        {
            const string scopePagePlacementText = "next-2";
            await _commonControls.ClickOnNextButtonPage(scopePagePlacementText);
        }

        [Given(@"I click on Next button from customer pricing page")]
        public async Task GivenIClickOnNextButtonFromCustomerPricingPage()
        {
            const string customerPricingPagePlacementText = "next-3";
            await _commonControls.ClickOnNextButtonPage(customerPricingPagePlacementText);
        }

        [Given(@"I click on Next button from questionnaire page")]
        public async Task GivenIClickOnNextButtonFromQuestionnairePage()
        {
            const string questionnairePagePlacementText = "next-5";
            await _commonControls.ClickOnNextButtonPage(questionnairePagePlacementText);
        }

        [Given(@"I enter ""([^""]*)"" into the textbox for the question ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxForTheQuestion(string p0, string p1)
        {
            await _commonControls.EnterValueInTextBoxBasedOnQuestion(p1, p0);
        }
    }
}
