using CPQUI.Drivers;
using CPQUI.Pages;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUIMarginAsSoldServiceStepDefinitions
    {
        private readonly Driver _driver;
        private readonly ConfigureMASPage _configureMASPage;
        
        CPQUIMarginAsSoldServiceStepDefinitions(Driver driver)
        {
            _driver = driver;
            _configureMASPage = new ConfigureMASPage(_driver.Page);
        }

        [Given(@"I Enter Business Volume for MAS as ""([^""]*)""")]
        public async Task GivenIEnterBusinessVolumeForMASAs(string p0)
        {
            await _configureMASPage.EnterBusinessVolume(p0);
        }

        [Given(@"I Enter License Cost for MAS as ""([^""]*)""")]
        public async Task GivenIEnterLicenseCostForMASAs(string p0)
        {
            await _configureMASPage.EnterLicenseCost(p0);
        }

        [Given(@"I Enter Third Party Delivery Cost for MAS as ""([^""]*)""")]
        public async Task GivenIEnterThirdPartyDeliveryCostForMASAs(string p0)
        {
            await _configureMASPage.EnterThirdPartyDeliveryCost(p0);
        }

        [Given(@"I Enter Internal Deliveyr Cost for MAS as ""([^""]*)""")]
        public async Task GivenIEnterInternalDeliveyrCostForMASAs(string p0)
        {
            await _configureMASPage.EnterInternalDeliveryCost(p0);
        }

        [When(@"I Click on Next Button from MAS Page")]
        public async Task WhenIClickOnNextButtonFromMASPage()
        {
            const string masPagePlacement = "next-4";
            await _configureMASPage.ClickNextButtonFromConfigureMASPage(masPagePlacement);
        }
    }
}
