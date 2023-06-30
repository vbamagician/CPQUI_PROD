using CPQUI.Drivers;
using CPQUI.Pages;

/*
*********************************************************************************************
Note:
*********************************************************************************************
1. General Services for Azure has now cotracts available from 5th June 2023. Hence there is 
    no need of closing the popup window step. 
*********************************************************************************************
*/

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUIProfessionalServicesWizardStepDefinitions
    {

        private readonly Driver _driver;
        private readonly SolutionsPage _solutionsPage;
        private readonly DefinitionPage _definitionPage;
        private readonly ScopePage _scopePage;
        private readonly CustomerPricingPage _customerPricingPage;
        private readonly OtherCostsPage _otherCostsPage;
        private readonly CustomerVariablesPage _customerVariablesPage;
        private readonly OpportunityPage _opportunityPage;

        CPQUIProfessionalServicesWizardStepDefinitions(Driver driver)
        {
            _driver = driver;
            _solutionsPage = new SolutionsPage(_driver.Page);
            _definitionPage = new DefinitionPage(_driver.Page);
            _scopePage = new ScopePage(_driver.Page);
            _customerPricingPage = new CustomerPricingPage(_driver.Page);
            _otherCostsPage = new OtherCostsPage(_driver.Page);
            _customerVariablesPage = new CustomerVariablesPage(_driver.Page);
            _opportunityPage = new OpportunityPage(_driver.Page);
        }

        [Given(@"I click on Configure Now Button")]
        public async Task GivenIClickOnConfigureNowButton()
        {
            await _solutionsPage.ClickOnConfigureButton();
        }

        [Given(@"I close Contract Unavailable Popup Window")]
        public async Task GivenICloseContractUnavailablePopupWindow()
        {
            await _definitionPage.ClosePopupWindow();
        }

        [Given(@"I choose Time & Material from Type of Contract Question")]
        public async Task GivenIChooseTimeMaterialFromTypeOfContractQuestion()
        {
            await _definitionPage.ChooseTimeMaterialFromTypeOfContractQuestion();
        }

        [Given(@"I entered Contract Duration in Month as ""([^""]*)""")]
        public async Task GivenIEnteredContractDurationInMonthAs(string p0)
        {
            await _definitionPage.EnterContractDurationInMonths(p0);
        }

        [Given(@"I click on Next Button From Definition Page")]
        public async Task GivenIClickOnNextButtonFromDefinitionPage()
        {
            const string definitionPagePlacement = "next-1";
            await _definitionPage.ClickOnNextButtonFromDefinitionPage(definitionPagePlacement);
        }

        [Given(@"I choose ""([^""]*)"" Option from build your plan Question")]
        public async Task GivenIChooseOptionFromBuildYourPlanQuestion(string days)
        {
            await _scopePage.ChooseOptionFromBuildYourPlanQuestion(days);
        }

        [Given(@"I downloaded the WBS template and saved as ""([^""]*)""")]
        public async Task GivenIDownloadedTheWBSTemplateAndSavedAs(string p0)
        {
            await _scopePage.DownloadWBSFile(p0);
        }

        [Given(@"I click on Import Button")]
        public async Task GivenIClickOnImportButton()
        {
            await _scopePage.ClickOnImportButton();
        }

        [Given(@"I click on Choose Files Button and Choose ""([^""]*)"" File")]
        public async Task GivenIClickOnChooseFilesButtonAndChooseFile(string p0)
        {
            await _scopePage.UploadWBSFile(p0);
        }

        [When(@"I click on Upload Button")]
        public async Task WhenIClickOnUploadButton()
        {
            await _scopePage.ClickOnUploadButton();
        }

        [Then(@"I should see the sell prices of import task as ""([^""]*)""")]
        public async Task ThenIShouldSeeTheSellPricesOfImportTaskAs(string p0)
        {
            bool IsEqual = await _scopePage.IfImportedSellPriceMatches(p0);
            IsEqual.Should().BeTrue();
        }

        [Given(@"I click on Add Button to add new Task")]
        public async Task GivenIClickOnAddButtonToAddNewTask()
        {
            await _scopePage.ClickOnAddButtonToAddNewTask();
        }

        [Given(@"I Entered Title of the Task as ""([^""]*)""")]
        public async Task GivenIEnteredTitleOfTheTaskAs(string p0)
        {
            await _scopePage.EnterTitleOfTheTask(p0);
        }

        [Given(@"I Entered Efforts of the Task as ""([^""]*)""")]
        public async Task GivenIEnteredEffortsOfTheTaskAs(string p0)
        {
            await _scopePage.EnterEffortsOfTheTask(p0);
        }

        [Given(@"I selected resource as Consultant as option number ""([^""]*)""")]
        public async Task GivenISelectedResourceAsConsultantAsOptionNumber(string p0)
        {
            await _scopePage.SelectResource(p0);
        }

        [Given(@"I selected country as ""([^""]*)""")]
        public async Task GivenISelectedCountryAs(string p0)
        {
            await _scopePage.SelectCoutry(p0);
        }

        [When(@"I click on Confirm Button")]
        public async Task WhenIClickOnConfirmButton()
        {
            await _scopePage.ClickOnConfirmButton();
        }

        [Then(@"I should see the sell price of the manual Task as ""([^""]*)""")]
        public async Task ThenIShouldSeeTheSellPriceOfTheManualTaskAs(string p0)
        {
            bool IsEqual = await _scopePage.IfInsertedSellPriceMatches(p0);
            IsEqual.Should().BeTrue();
        }

        [Then(@"I click on Next Button from Scoping Page")]
        public async Task ThenIClickOnNextButtonFromScopingPage()
        {
            const string scopingPagePlacement = "next-2";
            await _scopePage.ClickOnNextButtonFromScopingPage(scopingPagePlacement);
        }

        [Then(@"I click on Next Button from OtherCosts Page")]
        public async Task ThenIClickOnNextButtonFromOtherCostsPage()
        {
            const string otherCostsPagePlacement = "next-3";
            await _otherCostsPage.ClickOnNextButtonFromOtherCostsPage(otherCostsPagePlacement);
        }

        [Then(@"I click on Next Button from CustomerPricing Page")]
        public async Task ThenIClickOnNextButtonFromCustomerPricingPage()
        {
            const string customerPricingPagePlacement = "next-4";
            await _customerPricingPage.ClickOnNextButtonFromCustomerPricingPage(customerPricingPagePlacement);
        }

        [When(@"I click on Finish Button from CustomerVariables Page")]
        public async Task WhenIClickOnFinishButtonFromCustomerVariablesPage()
        {
            const string customerVariablePagePlacement = "finish";
            await _customerVariablesPage.ClickOnFinishButtonFromCustomerVariablesPage(customerVariablePagePlacement);
        }

        [Then(@"I should see the Opprtunity Value as ""([^""]*)""")]
        public async Task ThenIShouldSeeTheOpprtunityValueAs(string p0)
        {
            bool IsEqual = await _opportunityPage.IsValueOfOpportunityExpected(p0);
            IsEqual.Should().BeTrue();
        }
    }
}
