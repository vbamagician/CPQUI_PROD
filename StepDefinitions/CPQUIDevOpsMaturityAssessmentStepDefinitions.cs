using CPQUI.Drivers;
using CPQUI.Pages;
using System;
using TechTalk.SpecFlow;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUIDevOpsMaturityAssessmentStepDefinitions
    {

        private readonly Driver _driver;
        private readonly ScopePage _scopePage;
        private readonly CustomerPricingPage _customerPricingPage;
        private readonly MarginAsSoldPage _marginAsSoldPage;

        CPQUIDevOpsMaturityAssessmentStepDefinitions(Driver driver)
        {
            _driver = driver;
            _scopePage = new ScopePage(_driver.Page);
            _customerPricingPage = new CustomerPricingPage(_driver.Page);
            _marginAsSoldPage = new MarginAsSoldPage(_driver.Page);
        }

        [Given(@"I choose option ""([^""]*)"" for a question ""([^""]*)""")]
        public async Task GivenIChooseOptionForAQuestion(string yes, string p1)
        {
            await _scopePage.SelectOptionFromRadioButtonGroupForDMA(p1, yes);
        }

        [Given(@"I click on Next button from scope page for DMA")]
        public async Task GivenIClickOnNextButtonFromScopePageForDMA()
        {
            const string scopePagePlacementText = "next-2";
            await _scopePage.ClickOnNextButtonFromScopingPage(scopePagePlacementText);
        }

        [Given(@"I click on Next button from Customer Pricing page for DMA")]
        public async Task GivenIClickOnNextButtonFromCustomerPricingPageForDMA()
        {
            const string customerPricingPagePlacementText = "next-3";
            await _customerPricingPage.ClickOnNextButtonFromCustomerPricingPage(customerPricingPagePlacementText);
        }

        [Given(@"I click on Next button from Margin As Sold Page for DMA")]
        public async Task GivenIClickOnNextButtonFromMarginAsSoldPageForDMA()
        {
            const string marginAsSoldPagePlacementText = "next-4";
            await _marginAsSoldPage.ClickOnNextButtonFromMarginAsSoldPage(marginAsSoldPagePlacementText);
        }
    }
}
