using CPQUI.Drivers;
using CPQUI.Pages;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUIServicesCalculatorExcelStepDefinitions
    {

        private readonly Driver _driver;
        private readonly ServiceCalculatorPage _serviceCalculatorPage;
        private readonly MarginAsSoldPage _marginAsSoldPage;
        private readonly OpportunityPage _opportunityPage;

        CPQUIServicesCalculatorExcelStepDefinitions(Driver driver)
        {
            _driver = driver;
            _serviceCalculatorPage = new ServiceCalculatorPage(_driver.Page);
            _marginAsSoldPage = new MarginAsSoldPage(_driver.Page);
            _opportunityPage = new OpportunityPage(_driver.Page);
        }

        [Given(@"I click on Download Button to download configurator for EBC")]
        public async Task GivenIClickOnDownloadButtonToDownloadConfiguratorForEBC()
        {
            await _serviceCalculatorPage.DownloadCalculator();
        }

        [Given(@"I see the popup window and close it")]
        public async Task GivenISeeThePopupWindowAndCloseIt()
        {
            await _serviceCalculatorPage.ClosePopupWindow();
        }

        [Given(@"I upload the Excel based configurator")]
        public async Task GivenIUploadTheExcelBasedConfigurator()
        {
            await _serviceCalculatorPage.UploadCalculator();
        }

        [Given(@"I click next from ScopePage for EBC")]
        public async Task GivenIClickNextFromScopePageForEBC()
        {
            const string scopePagePlacement = "next-2";
            await _serviceCalculatorPage.ClickOnNextButtonFromServiceCalculatorPage(scopePagePlacement);
        }

        [When(@"When I click Finish from Margin As Sold Page for EBC")]
        public async Task WhenWhenIClickFinishFromMarginAsSoldPageForEBC()
        {
            const string marginPagePlacement = "finish";
            await _marginAsSoldPage.ClickOnFinishBttonFromMarginAsSoldPage(marginPagePlacement);
        }

        [Then(@"I should see the value of contract would be ""([^""]*)"" for EBC")]
        public async Task ThenIShouldSeeTheValueOfContractWouldBeForEBC(string p0)
        {
            bool IsEqual = await _opportunityPage.IsValueOfOpportunityExpected(p0);
            IsEqual.Should().BeTrue();
        }
    }
}
