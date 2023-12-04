using CPQUI.Drivers;
using CPQUI.Pages;
using CPQUI.Solutions;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUIOracleAdviosryServicesStepDefinitions
    {
        private readonly Driver _driver;
        private readonly SolutionsPage _solutionsPage;
        private readonly OracleAdvisoryServicesSolution _oracleAdvisoryServicesSolution;


        CPQUIOracleAdviosryServicesStepDefinitions(Driver driver)
        {
            _driver = driver;
            _solutionsPage = new SolutionsPage(_driver.Page);
            _oracleAdvisoryServicesSolution = new OracleAdvisoryServicesSolution(_driver.Page);
        }

        [Given(@"I click on Specific Service ""([^""]*)""")]
        public async Task GivenIClickOnSpecificService(string p0)
        {
            await _solutionsPage.SelectSpecificSolution(p0);
        }

        [Given(@"I click on Next button from definition page for OAS")]
        public async Task GivenIClickOnNextButtonFromDefinitionPageForOAS()
        {
            const string definitionPagePlacementText = "next-1";
            await _oracleAdvisoryServicesSolution.ClickOnNextButtonPage(definitionPagePlacementText);
        }

        [Given(@"I enter ""([^""]*)"" into the textbox for the question Number of documents for the ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxForTheQuestionNumberOfDocumentsForThe(string p0, string p1)
        {
            await _oracleAdvisoryServicesSolution.EnterValueInTextBoxBasedOnHeader(p1, p0);
        }

        [Given(@"I enter ""([^""]*)"" into the textbox for the question Number of servers for the ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxForTheQuestionNumberOfServersForThe(string p0, string p1)
        {
            await _oracleAdvisoryServicesSolution.EnterValueInTextBoxBasedOnHeader(p1, p0);
        }

        [Given(@"I enter ""([^""]*)"" into the textbox for the question Number of environments for the ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxForTheQuestionNumberOfEnvironmentsForThe(string p0, string p1)
        {
            await _oracleAdvisoryServicesSolution.EnterValueInTextBoxBasedOnHeader(p1, p0);
        }

        [Given(@"I enter ""([^""]*)"" into the textbox for the question Number of targets & sources for the ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxForTheQuestionNumberOfTargetsSourcesForThe(string p0, string goldenGate)
        {
            await _oracleAdvisoryServicesSolution.EnterValueInTextBoxBasedOnHeader(goldenGate, p0);
        }

        [Given(@"I enter ""([^""]*)"" into the textbox for the question Number of users for the ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxForTheQuestionNumberOfUsersForThe(string p0, string p1)
        {
            await _oracleAdvisoryServicesSolution.EnterValueInTextBoxBasedOnHeader(p1, p0);
        }

        [Given(@"I enter ""([^""]*)"" into the textbox for the question Number of hours for the ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxForTheQuestionNumberOfHoursForThe(string p0, string p1)
        {
            await _oracleAdvisoryServicesSolution.EnterValueInTextBoxBasedOnHeader(p1, p0);
        }

        [Given(@"I click on Next button from scope page for OAS")]
        public async Task GivenIClickOnNextButtonFromScopePageForOAS()
        {
            const string scopePagePlacementText = "next-2";
            await _oracleAdvisoryServicesSolution.ClickOnNextButtonPage(scopePagePlacementText);
        }

        [Given(@"I click on Next button from customer pricing page for OAS")]
        public async Task GivenIClickOnNextButtonFromCustomerPricingPageForOAS()
        {
            const string customerPricingPagePlacementText = "next-3";
            await _oracleAdvisoryServicesSolution.ClickOnNextButtonPage(customerPricingPagePlacementText);
        }

        [Given(@"I enter ""([^""]*)"" into the textarea for the question ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextareaForTheQuestion(string aBCD, string p1)
        {
            await _oracleAdvisoryServicesSolution.EnterValueInTextAreaBasedOnQuestion(p1, aBCD);
        }

        [Given(@"I click on Next button from customer questionnaire page for OAS")]
        public async Task GivenIClickOnNextButtonFromCustomerQuestionnairePageForOAS()
        {
            const string questionnairePagePlacementText = "next-5";
            await _oracleAdvisoryServicesSolution.ClickOnNextButtonPage(questionnairePagePlacementText);
        }
    }
}
