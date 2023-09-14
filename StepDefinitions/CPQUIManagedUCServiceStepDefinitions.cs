using CPQUI.Drivers;
using CPQUI.Pages;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUIManagedUCServiceStepDefinitions
    {
        private readonly Driver _driver;
        private readonly DefinitionPage _definitionPage;
        private readonly ScopePage _scopePage;
        private readonly CustomerPricingPage _customerPricingPage;
        private readonly MarginAsSoldPage _marginAsSoldPage;
        private readonly QuestionnairePage _questionnairePage;
        
        CPQUIManagedUCServiceStepDefinitions(Driver driver)
        {
            _driver = driver;
            _definitionPage = new DefinitionPage(_driver.Page);
            _scopePage = new ScopePage(_driver.Page);
            _customerPricingPage = new CustomerPricingPage(_driver.Page);
            _marginAsSoldPage = new MarginAsSoldPage(_driver.Page);
            _questionnairePage = new QuestionnairePage(_driver.Page);
        }

        [Given(@"I select option Managed Unified Communications Voice for Optional Services")]
        public async Task GivenISelectOptionManagedUnifiedCommunicationsVoiceForOptionalServices()
        {
            await _definitionPage.SelectOptionManagedUnifiedCommunicationsVoiceForOptionalServices();
        }

        [Given(@"I select option Yes for Is Voice Infrastructure support required")]
        public async Task GivenISelectOptionYesForIsVoiceInfrastructureSupportRequired()
        {
            await _definitionPage.SelectOptionYesForIsVoiceInfrastructureSupportRequired();
        }

        [Given(@"I select option No for Is Call Route required")]
        public async Task GivenISelectOptionNoForIsCallRouteRequired()
        {
           await _definitionPage.SelectOptionNoForIsCallRouteRequired();
        }

        [Given(@"I click on Next Button From Definition Page for MUC")]
        public async Task GivenIClickOnNextButtonFromDefinitionPageForMUC()
        {
            const string definitionPagePlacement = "next-1";
            await _definitionPage.ClickOnNextButtonFromDefinitionPage(definitionPagePlacement);
        }

        [Given(@"I choose option three Year for Agreement Term")]
        public async Task GivenIChooseOptionThreeYearForAgreementTerm()
        {
            await _scopePage.ChooseOptionYearForAgreementTerm();
        }

        [Given(@"I entered hundred as Number of Users")]
        public async Task GivenIEnteredHundredAsNumberOfUsers()
        {
            await _scopePage.EnterNumberOfUsers();
        }

        [Given(@"I entered hundred as Number of Devices")]
        public async Task GivenIEnteredHundredAsNumberOfDevices()
        {
            await _scopePage.EnterNumberOfDevices();
        }

        [Given(@"I click Next on Scope Page for MUC")]
        public async Task GivenIClickNextOnScopePageForMUC()
        {
            const string scopingPagePlacement = "next-2";
            await _scopePage.ClickOnNextButtonFromScopingPage(scopingPagePlacement);
        }

        [Given(@"I click on Next Button from Customer Pricing Page for MUC")]
        public async Task GivenIClickOnNextButtonFromCustomerPricingPageForMUC()
        {
            const string customerPricingPagePlacement = "next-3";
            await _customerPricingPage.ClickOnNextButtonFromCustomerPricingPage(customerPricingPagePlacement);
        }

        [Given(@"I click on Next Button from Margin As Sold Page for MUC")]
        public async Task GivenIClickOnNextButtonFromMarginAsSoldPageForMUC()
        {
            const string marginPagePlacement = "next-4";
            await _marginAsSoldPage.ClickOnNextButtonFromMarginAsSoldPage(marginPagePlacement);
        }

        [Given(@"I entered name as random value for Microsoft Office Tenant")]
        public async Task GivenIEnteredNameAsRandomValueForMicrosoftOfficeTenant()
        {
            await _questionnairePage.EnteredNameAsRandomValueForMicrosoftOfficeTenant();
        }

        [Given(@"I click on Next Button from Questionnaire Page for MUC")]
        public async Task GivenIClickOnNextButtonFromQuestionnairePageForMUC()
        {
            const string questionairePagePlacement = "next-5";
            await _questionnairePage.ClickOnNextButtonFromQuestionnairePage(questionairePagePlacement);
        }
    }
}
