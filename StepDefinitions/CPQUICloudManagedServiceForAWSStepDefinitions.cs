using CPQUI.Drivers;
using CPQUI.Solutions;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUICloudManagedServiceForAWSStepDefinitions
    {
        private readonly Driver _driver;
        private readonly CloudManagedServiceForAWSSolution _cloudManagedServiceForAWSSolution;


        CPQUICloudManagedServiceForAWSStepDefinitions(Driver driver)
        {
            _driver = driver;
            _cloudManagedServiceForAWSSolution = new CloudManagedServiceForAWSSolution(_driver.Page);
        }

        [Given(@"I select option as ""([^""]*)"" from available Services Tiers in scope")]
        public async Task GivenISelectOptionAsFromAvailableServicesTiersInScope(string essentials)
        {
            await _cloudManagedServiceForAWSSolution.SelectServiceForCloudManagedServicesForAWS(essentials);
        }

        [Given(@"I click on Next button from definition page for CMSAWS")]
        public async Task GivenIClickOnNextButtonFromDefinitionPageForCMSAWS()
        {
            const string definitionPagePlacementText = "next-1";
            await _cloudManagedServiceForAWSSolution.ClickOnNextButtonPage(definitionPagePlacementText);
        }

        [Given(@"I entered ""([^""]*)"" in a textbox of a question ""([^""]*)""")]
        public async Task GivenIEnteredInATextboxOfAQuestion(string p0, string p1)
        {
            await _cloudManagedServiceForAWSSolution.EnterValueInTextBoxBasedOnQuestion(p1, p0);
        }

        [Given(@"I choose ""([^""]*)"" from radio button group of a question ""([^""]*)""")]
        public async Task GivenIChooseFromRadioButtonGroupOfAQuestion(string no, string p1)
        {
            await _cloudManagedServiceForAWSSolution.ChooseRadioButtonBasedOnQuestion(p1, no);
        }

        [Given(@"I choose ""([^""]*)"" from dropdown box of a question ""([^""]*)""")]
        public async Task GivenIChooseFromDropdownBoxOfAQuestion(string p0, string p1)
        {
            await _cloudManagedServiceForAWSSolution.ChooseDropDownItemBasedOnQuestion(p1, p0);
        }

        [Given(@"I click on Next button from scope page for CMSAWS")]
        public async Task GivenIClickOnNextButtonFromScopePageForCMSAWS()
        {
            const string scopePagePlacementText = "next-2";
            await _cloudManagedServiceForAWSSolution.ClickOnNextButtonPage(scopePagePlacementText);
        }

        [Given(@"I click on Next button from customer pricing page for CMSAWS")]
        public async Task GivenIClickOnNextButtonFromCustomerPricingPageForCMSAWS()
        {
            const string customerPricingPagePlacementText = "next-3";
            await _cloudManagedServiceForAWSSolution.ClickOnNextButtonPage(customerPricingPagePlacementText);
        }

        [Given(@"I click on Next button from customer questionnaire page for CMSAWS")]
        public async Task GivenIClickOnNextButtonFromCustomerQuestionnairePageForCMSAWS()
        {
            const string questionnairePagePlacementText = "next-5";
            await _cloudManagedServiceForAWSSolution.ClickOnNextButtonPage(questionnairePagePlacementText);
        }
    }
}
