using CPQUI.Controls;
using CPQUI.Drivers;
using CPQUI.Solutions;

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

        [Given(@"I click on Next button from definition page for CASP")]
        public async Task GivenIClickOnNextButtonFromDefinitionPageForCASP()
        {
            const string definitionPagePlacementText = "next-1";
            await _commonControls.ClickOnNextButtonPage(definitionPagePlacementText);
        }

        [Given(@"I enter ""([^""]*)"" into the textbox for the question ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxForTheQuestion(string p0, string p1)
        {
            await _commonControls.EnterValueInTextBoxBasedOnQuestion(p1, p0);
        }

        [Given(@"I click on Next button from scope page for CASP")]
        public async Task GivenIClickOnNextButtonFromScopePageForCASP()
        {
            const string scopePagePlacementText = "next-2";
            await _commonControls.ClickOnNextButtonPage(scopePagePlacementText);
        }

        [Given(@"I click on Next button from customer pricing page for CASP")]
        public async Task GivenIClickOnNextButtonFromCustomerPricingPageForCASP()
        {
            const string customerPricingPagePlacementText = "next-3";
            await _commonControls.ClickOnNextButtonPage(customerPricingPagePlacementText);
        }

        [Given(@"I click on Next button from questionnaire page for CASP")]
        public async Task GivenIClickOnNextButtonFromQuestionnairePageForCASP()
        {
            const string questionnairePagePlacementText = "next-5";
            await _commonControls.ClickOnNextButtonPage(questionnairePagePlacementText);
        }
    }
}
