using CPQUI.Drivers;
using CPQUI.Pages;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUIMicrosoftAgreementServiceStepDefinitions
    {

        private readonly Driver _driver;
        private readonly DefinitionPage _definitionPage;
        private readonly ScopePage _scopePage;
        private readonly CustomerPricingPage _customerPricingPage;
        private readonly MarginAsSoldPage _marginAsSoldPage;
        private readonly QuestionnairePage _questionnairePage;
        private readonly ContactsPage _contactsPage;
        private readonly OpportunityPage _opportunityPage;

        CPQUIMicrosoftAgreementServiceStepDefinitions(Driver driver)
        {
            _driver = driver;
            _definitionPage = new DefinitionPage(_driver.Page);
            _scopePage = new ScopePage(_driver.Page);
            _customerPricingPage = new CustomerPricingPage(_driver.Page);
            _marginAsSoldPage = new MarginAsSoldPage(_driver.Page);
            _questionnairePage = new QuestionnairePage(_driver.Page);
            _contactsPage = new ContactsPage(_driver.Page);
            _opportunityPage = new OpportunityPage(_driver.Page);
        }

        [Given(@"I select Pack Managed LSP Checkbox")]
        public async Task GivenISelectPackManagedLSPCheckbox()
        {
            throw new PendingStepException();
        }

        [Given(@"I click on Next Button From Definition Page for MSA")]
        public async Task GivenIClickOnNextButtonFromDefinitionPageForMSA()
        {
            const string definitionPagePlacement = "next-1";
            await _definitionPage.ClickOnNextButtonFromDefinitionPage(definitionPagePlacement);
        }

        [Given(@"I click on Add Buton to mention Agreemnt that customer going to sign with Microsoft")]
        public async Task GivenIClickOnAddButonToMentionAgreemntThatCustomerGoingToSignWithMicrosoft()
        {
            throw new PendingStepException();
        }

        [Given(@"I choose Enrollment Type as EA")]
        public async Task GivenIChooseEnrollmentTypeAsEA()
        {
            throw new PendingStepException();
        }

        [Given(@"I choose Price Level as A")]
        public async Task GivenIChoosePriceLevelAsA()
        {
            throw new PendingStepException();
        }

        [Given(@"I enter Annual Amount as ""([^""]*)""")]
        public async Task GivenIEnterAnnualAmountAs(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I click on Submit Button")]
        public async Task GivenIClickOnSubmitButton()
        {
            throw new PendingStepException();
        }

        [Given(@"I click Next on Scope Page for MSA")]
        public async Task GivenIClickNextOnScopePageForMSA()
        {
            const string scopingPagePlacement = "next-2";
            await _scopePage.ClickOnNextButtonFromScopingPage(scopingPagePlacement);
        }

        [Given(@"I click Next Customer Pricing Page for MSA")]
        public async Task GivenIClickNextCustomerPricingPageForMSA()
        {
            const string customerPricingPagePlacement = "next-3";
            await _customerPricingPage.ClickOnNextButtonFromCustomerPricingPage(customerPricingPagePlacement);
        }

        [Given(@"I click Next Margin As Sold Page for MSA")]
        public async Task GivenIClickNextMarginAsSoldPageForMSA()
        {
            const string marginPagePlacement = "next-4";
            await _marginAsSoldPage.ClickOnNextButtonFromMarginAsSoldPage(marginPagePlacement);
        }

        [Given(@"I choose Remote option for FinOps Fundamentals and KickOff")]
        public async Task GivenIChooseRemoteOptionForFinOpsFundamentalsAndKickOff()
        {
            throw new PendingStepException();
        }

        [Given(@"I choose Remote option for Spend Management Implementation or Onboarding")]
        public async Task GivenIChooseRemoteOptionForSpendManagementImplementationOrOnboarding()
        {
            throw new PendingStepException();
        }

        [Given(@"I choose Remote option for PyraCloud Spend Management Training")]
        public async Task GivenIChooseRemoteOptionForPyraCloudSpendManagementTraining()
        {
            throw new PendingStepException();
        }

        [Given(@"I choose Remote option for Cloud Cost Optimization Implementation")]
        public async Task GivenIChooseRemoteOptionForCloudCostOptimizationImplementation()
        {
            throw new PendingStepException();
        }

        [Given(@"I click Next on Questionaire Page for MSA")]
        public async Task GivenIClickNextOnQuestionairePageForMSA()
        {
            const string questionairePagePlacement = "next-5";
            await _questionnairePage.ClickOnNextButtonFromQuestionnairePage(questionairePagePlacement);
        }

        [When(@"I click Finish on Contacts Page for MSA")]
        public async Task WhenIClickFinishOnContactsPageForMSA()
        {
            const string contactsPagePlacement = "finish";
            await _contactsPage.ClickOnFinishButtonFromContactsPage(contactsPagePlacement);
        }
    }
}
