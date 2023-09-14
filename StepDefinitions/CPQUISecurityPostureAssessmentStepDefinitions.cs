using CPQUI.Drivers;
using CPQUI.Pages;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUISecurityPostureAssessmentStepDefinitions
    {
        private readonly Driver _driver;
        private readonly SolutionsPage _solutionsPage;
        private readonly ScopePage _scopePage;
        private readonly CustomerPricingPage _customerPricingPage;
        private readonly MarginAsSoldPage _marginAsSoldPage;
        private readonly QuestionnairePage _questionnairePage;
        private readonly ContactsPage _contactsPage;

        CPQUISecurityPostureAssessmentStepDefinitions(Driver driver)
        {
            _driver = driver;
            _solutionsPage = new SolutionsPage(_driver.Page);
            _scopePage = new ScopePage(_driver.Page);
            _customerPricingPage = new CustomerPricingPage(_driver.Page);
            _marginAsSoldPage = new MarginAsSoldPage(_driver.Page);
            _questionnairePage = new QuestionnairePage(_driver.Page);
            _contactsPage = new ContactsPage(_driver.Page);
        }

        [Given(@"I click on Configure Now Button for SPAE")]
        public async Task GivenIClickOnConfigureNowButtonForSPAE()
        {
            await _solutionsPage.ClickOnConfigureButton();
        }

        [Given(@"I Entered Value for technical assessment for SPAE as ""([^""]*)""")]
        public async Task GivenIEnteredValueForTechnicalAssessmentForSPAEAs(string p0)
        {
            await _scopePage.EnteredValueForTechnicalAssessmentForSPAEA(p0);
        }

        [Given(@"I Choose Yes for serverless based workloads for SPAE")]
        public async Task GivenIChooseYesForServerlessBasedWorkloadsForSPAE()
        {
            await _scopePage.ChooseYesForServerlessBasedWorkloadsForSPAE();
        }

        [Given(@"I click Next on Scope Page for SPAE")]
        public async Task GivenIClickNextOnScopePageForSPAE()
        {
            const string scopePagePlacement = "next-2";
            await _scopePage.ClickOnNextButtonFromScopingPage(scopePagePlacement);
        }

        [Given(@"I Choose Days to Build My Plan for SPAE")]
        public async Task GivenIChooseDaysToBuildMyPlanForSPAE()
        {
            await _customerPricingPage.IChoosePlanInDays();
        }

        [Given(@"I click Next Customer Pricing Page for SPAE")]
        public async Task GivenIClickNextCustomerPricingPageForSPAE()
        {
            const string customerPricingPagePlacement = "next-3";
            await _customerPricingPage.ClickOnNextButtonFromCustomerPricingPage(customerPricingPagePlacement);
        }

        [Given(@"I click Next Margin As Sold Page for SPAE")]
        public async Task GivenIClickNextMarginAsSoldPageForSPAE()
        {
            const string marginPagePlacement = "next-4";
            await _marginAsSoldPage.ClickOnNextButtonFromMarginAsSoldPage(marginPagePlacement);
        }

        [Given(@"I fill Questionnaire Page questions for SPAE")]
        public async Task GivenIFillQuestionnairePageQuestionsForSPAE()
        {
            await _questionnairePage.FillQuestionnairePageQuestionsForSPA();
        }

        [Given(@"I click Next on Questionaire Page for SPAE")]
        public async Task GivenIClickNextOnQuestionairePageForSPAE()
        {
            const string questionnairePagePlacement = "next-5";
            await _questionnairePage.ClickOnNextButtonFromQuestionnairePage(questionnairePagePlacement);
        }

        [Given(@"I Add Authorized Contacts for SPAE")]
        public async Task GivenIAddAuthorizedContactsForSPAE()
        {
            const string contactsPagePlacement = "finish";
            await _contactsPage.AddAuthorizedContacts(contactsPagePlacement);
        }

        [Given(@"I add Softwareone Contacts for SPAE")]
        public async Task GivenIAddSoftwareoneContactsForSPAE()
        {
            await _contactsPage.AddSoftwareoneContacts();
        }

        [Given(@"I Select Document Type as PDF for APAE")]
        public async Task GivenISelectDocumentTypeAsPDFForAPAE()
        {
            await _contactsPage.SelectDocumentTypeAsPDF();
        }

        [When(@"I click Finish on Contacts Page for SPAE")]
        public async Task WhenIClickFinishOnContactsPageForSPAE()
        {
            const string contactsPagePlacement = "finish";
            await _contactsPage.ClickOnFinishButtonFromContactsPage(contactsPagePlacement);
        }
    }
}
