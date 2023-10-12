using CPQUI.Drivers;
using CPQUI.Solutions;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUICloudManagedServiceForAzureStepDefinitions
    {

        private readonly Driver _driver;
        private readonly CloudManagedServiceForAzureSolution _cloudManagedServiceForAzureSolution;


        CPQUICloudManagedServiceForAzureStepDefinitions(Driver driver)
        {
            _driver = driver;
            _cloudManagedServiceForAzureSolution = new CloudManagedServiceForAzureSolution(_driver.Page);
        }

        [Given(@"I select option as ""([^""]*)"" for service selection of Azure Essential for CSP")]
        public async Task GivenISelectOptionAsForServiceSelectionOfAzureEssentialForCSP(string yes)
        {
            await _cloudManagedServiceForAzureSolution.SelectOptionForServiceSelectionOfAzureEssentialForCSP(yes);
        }

        [Given(@"I select option as ""([^""]*)"" for service selection of Azure Essentials for EA")]
        public async Task GivenISelectOptionAsForServiceSelectionOfAzureEssentialsForEA(string yes)
        {
            await _cloudManagedServiceForAzureSolution.SelectOptionForServiceSelectionOfAzureEssentialsForEA(yes);
        }

        [Given(@"I select option as ""([^""]*)"" for service selection of Azure Advanced")]
        public async Task GivenISelectOptionAsForServiceSelectionOfAzureAdvanced(string yes)
        {
            await _cloudManagedServiceForAzureSolution.SelectOptionForServiceSelectionOfAzureAdvanced(yes);
        }

        [Given(@"I click on Next button from Definition page for CMSA")]
        public async Task GivenIClickOnNextButtonFromDefinitionPageForCMSA()
        {
            const string definitionPagePlacementText = "next-1";
            await _cloudManagedServiceForAzureSolution.ClickOnNextButtonPage(definitionPagePlacementText);
        }

        [Given(@"I entered Estimated Consumption per month for Azure Essential for CSP as ""([^""]*)""")]
        public async Task GivenIEnteredEstimatedConsumptionPerMonthForAzureEssentialForCSPAs(string p0)
        {
            await _cloudManagedServiceForAzureSolution.EnterEstimatedConsumptionPerMonthForAzureEssentialForCSP(p0);
        }

        [Given(@"I choose option as ""([^""]*)"" about offering discount for Azure Essential for CSP")]
        public async Task GivenIChooseOptionAsAboutOfferingDiscountForAzureEssentialForCSP(string yes)
        {
            await _cloudManagedServiceForAzureSolution.ChooseOptionAboutOfferingDiscountForAzureEssentialForCSP(yes);
        }

        [Given(@"I entered discount percentage for Azure Essential for CSP as ""([^""]*)""")]
        public async Task GivenIEnteredDiscountPercentageForAzureEssentialForCSPAs(string p0)
        {
            await _cloudManagedServiceForAzureSolution.EnterDiscountPercentageForAzureEssentialForCSP(p0);
        }

        [Given(@"I entered Estimated Consumption per month for Azure Essentials for EA as ""([^""]*)""")]
        public async Task GivenIEnteredEstimatedConsumptionPerMonthForAzureEssentialsForEAAs(string p0)
        {
            await _cloudManagedServiceForAzureSolution.EnterEstimatedConsumptionPerMonthForAzureEssentialsForEA(p0);
        }

        [Given(@"I choose option as ""([^""]*)"" about offering discount for Azure Essentials for EA")]
        public async Task GivenIChooseOptionAsAboutOfferingDiscountForAzureEssentialsForEA(string yes)
        {
            await _cloudManagedServiceForAzureSolution.ChooseOptionAboutOfferingDiscountForAzureEssentialsForEA(yes);
        }

        [Given(@"I entered discount percentage for Azure Essentials for EA as ""([^""]*)""")]
        public async Task GivenIEnteredDiscountPercentageForAzureEssentialsForEAAs(string p0)
        {
            await _cloudManagedServiceForAzureSolution.EnterDiscountPercentageForAzureEssentialsForEA(p0);
        }

        [Given(@"I entered Estimated Consumption per month for Azure Advanced as ""([^""]*)""")]
        public async Task GivenIEnteredEstimatedConsumptionPerMonthForAzureAdvancedAs(string p0)
        {
            await _cloudManagedServiceForAzureSolution.EnterEstimatedConsumptionPerMonthForAzureAdvanced(p0);
        }

        [Given(@"I choose option as ""([^""]*)"" about offering discount for Azure Advanced")]
        public async Task GivenIChooseOptionAsAboutOfferingDiscountForAzureAdvanced(string yes)
        {
            await _cloudManagedServiceForAzureSolution.ChooseOptionAboutOfferingDiscountForAzureAdvanced(yes);
        }

        [Given(@"I entered discount percentage for Azure Advanced as ""([^""]*)""")]
        public async Task GivenIEnteredDiscountPercentageForAzureAdvancedAs(string p0)
        {
            await _cloudManagedServiceForAzureSolution.EnterDiscountPercentageForAzureAdvanced(p0);
        }

        [Given(@"I select option from dropdown for Azure Account Transfer as New CSP and value is ""([^""]*)""")]
        public async Task GivenISelectOptionFromDropdownForAzureAccountTransferAsNewCSPAndValueIs(string p0)
        {
            await _cloudManagedServiceForAzureSolution.SelectOptionForAzureAccountTransfer(p0);
        }

        [Given(@"I click on next button from scope page for CMSA")]
        public async Task GivenIClickOnNextButtonFromScopePageForCMSA()
        {
            const string scopePagePlacementText = "next-2";
            await _cloudManagedServiceForAzureSolution.ClickOnNextButtonPage(scopePagePlacementText);
        }

        [Given(@"I click on Next button from customer pricing page for CMSA")]
        public async Task GivenIClickOnNextButtonFromCustomerPricingPageForCMSA()
        {
            const string customerPricingPagePlacementText = "next-3";
            await _cloudManagedServiceForAzureSolution.ClickOnNextButtonPage(customerPricingPagePlacementText);
        }
    }
}
