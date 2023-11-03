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

        CPQUIServicesCalculatorExcelStepDefinitions(Driver driver)
        {
            _driver = driver;
            _serviceCalculatorPage = new ServiceCalculatorPage(_driver.Page);
            _marginAsSoldPage = new MarginAsSoldPage(_driver.Page);
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

        [When(@"When I click Finish from Scope Page for EBC")]
        public async Task WhenWhenIClickFinishFromScopePageForEBC()
        {
            const string scopePagePlacement = "finish";
            await _serviceCalculatorPage.ClickOnFinishButtonFromServiceCalculatorPage(scopePagePlacement);
        }

    }
}
