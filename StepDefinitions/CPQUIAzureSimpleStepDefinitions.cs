using CPQUI.Drivers;
using CPQUI.Pages;
using TechTalk.SpecFlow.Assist;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUIAzureSimpleStepDefinitions
    {
        private readonly Driver _driver;
        private readonly LoginPage _loginPage;
        private readonly ContractPage _contractPage;
        private readonly SolutionsPage _solutionsPage;
        private readonly ScopePage _scopePage;
        private readonly CustomerPricingPage _customerPricingPage;
        private readonly MarginAsSoldPage _marginAsSoldPage;
        private readonly QuestionnairePage _questionnairePage;
        private readonly ContactsPage _contactsPage;
        private readonly OpportunityPage _opportunityPage;

        CPQUIAzureSimpleStepDefinitions(Driver driver)
        {
            _driver = driver;
            _contractPage = new ContractPage(_driver.Page);
            _loginPage = new LoginPage(_driver.Page);
            _solutionsPage = new SolutionsPage(_driver.Page);
            _scopePage = new ScopePage(_driver.Page);
            _customerPricingPage = new CustomerPricingPage(_driver.Page);
            _marginAsSoldPage = new MarginAsSoldPage(_driver.Page);
            _questionnairePage = new QuestionnairePage(_driver.Page);
            _contactsPage = new ContactsPage(_driver.Page);
            _opportunityPage = new OpportunityPage(_driver.Page);
            
            Console.WriteLine("Instance Created");
        }

        [Given(@"I Navigate to CPQ UI Page")]
        public void GivenINavigateToCPQUIPage()
        {
            string? envMyFirstName = Environment.GetEnvironmentVariable("MyFirstName");
            Console.WriteLine($"{envMyFirstName}");

            //Define Environemtn Variable that decide what one to choose
            string? varenvspace = Environment.GetEnvironmentVariable("ENVSPACE");

            if (varenvspace == null)
            {
                //PROD
                _driver.Page.GotoAsync("https://contracts.softwareone.com/");
                //UAT
                //_driver.Page.GotoAsync("https://softwareone-cpq-uat.onknowledgekube.net/");
            }
            else if (varenvspace == "CLOUD")
            {
                string? pageLink = Environment.GetEnvironmentVariable("CPQUI_PAGE_LINK");
                if (pageLink == null)
                    _driver.Page.GotoAsync("https://contracts.softwareone.com/");
                else
                    _driver.Page.GotoAsync(pageLink);
            }
        }


        [Given(@"I Enter following Login Details and Click Login Button")]
        public async Task GivenIEnterFollowingLoginDetailsAndClickLoginButton(Table table)
        {
            //Define Environemtn Variable that decide what one to choose
            string? varenvspace = Environment.GetEnvironmentVariable("ENVSPACE");

            if (varenvspace == null)
            {
                Console.WriteLine("Local Credentilas User");
                //Login Mechanism for Local Repo
                dynamic data = table.CreateDynamicInstance();

                // Eliminated AESOperation for a time being 
                //var decryptedString = AESOperations.DecryptString("b14ca5898a4e4133bbce2ea2315a1916", (string)data.Password);

                await _loginPage.SSOLogin((string)data.Username, (string)data.Password);
            }
            else if (varenvspace == "CLOUD")
            {
                //Login Mechanism for AzureDevOps Pipeline
                Console.WriteLine("ENVSPACE Variable used");
                //Source Environment Variables
                string? username = Environment.GetEnvironmentVariable("CPQUI_LOGIN_USERNAME");
                string? password = Environment.GetEnvironmentVariable("CPQUI_LOGIN_PASSWORD");
                
                bool IsEqual;
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    IsEqual = false;
                } else
                {
                    IsEqual = true;
                }
                IsEqual.Should().BeTrue();

                await _loginPage.Login(username, password);
            }
        }

        [Given(@"I click on New Contract Button")]
        public async Task GivenIClickOnNewContractButton()
        {
            await _contractPage.ClickOnNewContractButton();
        }

        [Given(@"I configure client details for new Contract")]
        public async Task GivenIConfigureClientDetailsForNewContract()
        {
            await _contractPage.ConfigureClientDetailsForNewContract();
        }

        [Given(@"I click on Service ""([^""]*)""")]
        public async Task GivenIClickOnService(string p0)
        {
            await _solutionsPage.SelectSolution(p0);
        }

        [Given(@"I entered estimated consumption per month value as (.*)")]
        public async Task GivenIEnteredEstimatedConsumptionPerMonthValueAs(string p0)
        {
            await _scopePage.EnterEstimatedConsumptionPerMonthValue(p0);
        }

        [Given(@"I choose no discount")]
        public async Task GivenIChooseNoDiscount()
        {
            await _scopePage.ChooseNoDiscount();
        }

        [Given(@"I choose customer have existing account to transfer")]
        public async Task GivenIChooseCustomerHaveExistingAccountToTransfer()
        {
            await _scopePage.ChooseCustomerHaveExistingAccountToTransfer();
        }

        [Given(@"I click Next on Scope Page")]
        public async Task WhenIClickNextOnScopePage()
        {
            const string scopePagePlacement = "next-2";
            await _scopePage.ClickOnNextButtonFromScopingPage(scopePagePlacement);
        }

        [Given(@"I click Next Customer Pricing Page")]
        public async Task ThenIClickNextCustomerPricingPage()
        {
            const string customerPricingPagePlacement = "next-3";
            await _customerPricingPage.ClickOnNextButtonFromCustomerPricingPage(customerPricingPagePlacement);
        }

        [Given(@"I click Next Margin As Sold Page")]
        public async Task ThenIClickNextMarginAsSoldPage()
        {
            const string marginPagePlacement = "next-4";
            await _marginAsSoldPage.ClickOnNextButtonFromMarginAsSoldPage(marginPagePlacement);
        }

        [Given(@"I Add Microsoft Tenant")]
        public async Task ThenIAddMicrosoftTenant()
        {
            await _questionnairePage.AddMicrosoftTenant();
        }

        [Given(@"I entered prepayment amount as (.*)")]
        public async Task ThenIEnteredPrepaymentAmountAs(string p0)
        {
            await _questionnairePage.AddPrepaymentAmount(p0);
        }

        [Given(@"I click Next on Questionaire Page")]
        public async Task ThenIClickNextOnQuestionairePage()
        {
            const string questionairePagePlacement = "next-5"; 
            await _questionnairePage.ClickOnNextButtonFromQuestionnairePage(questionairePagePlacement);
        }

        [Given(@"I Add Authorized Contacts")]
        public async Task ThenIAddAuthorizedContacts()
        {
            const string contactsPagePlacement = "finish";
            await _contactsPage.AddAuthorizedContacts(contactsPagePlacement);
        }

        [Given(@"I add Softwareone Contacts")]
        public async Task ThenIAddSoftwareoneContacts()
        {
            await _contactsPage.AddSoftwareoneContacts();
        }

        [Given(@"I Select Document Type as PDF")]
        public async Task GivenISelectDocumentTypeAsPDF()
        {
            await _contactsPage.SelectDocumentTypeAsPDF();
        }

        [When(@"I click Finish on Contacts Page")]
        public async Task WhenIClickFinishOnContactsPage()
        {
            const string contactsPagePlacement = "finish";
            await _contactsPage.ClickOnFinishButtonFromContactsPage(contactsPagePlacement);
        }

        [Then(@"I should see the value of contract")]
        public async Task ThenIShouldSeeTheValueOfContract()
        {
            bool IsEqual = await _opportunityPage.IsValueOfOpportunityExpected();
            IsEqual.Should().BeTrue();
        }
    }
}