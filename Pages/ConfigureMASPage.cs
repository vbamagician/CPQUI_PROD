using CPQUI.Controls;
using Microsoft.Playwright;

/* 
-------------------------------------------------------------------------------------------------------------
    Important Notes
-------------------------------------------------------------------------------------------------------------
    1.  Update button removed from the application from 31st May 2023: Informed By Rajan
        private ILocator UpdateButton => _page.GetByRole(AriaRole.Button, new() { Name = " Update" });
------------------------------------------------------------------------------------------------------------
*/

namespace CPQUI.Pages
{
    internal class ConfigureMASPage
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        //Constructor
        public ConfigureMASPage(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        //Properties
        private ILocator BusinessVolumeTextBox => _page.Locator("//label[contains(text(),'Business Volume')]/../..//input");
        private ILocator LicenseCostTextBox => _page.Locator("//label[contains(text(),'License Cost')]/../..//input");
        private ILocator ThirdPartyDeliveryCostTextBox => _page.Locator("//label[contains(text(),'Third Party Delivery Cost')]/../..//input");
        private ILocator InternalDeliveryCostTextBox => _page.Locator("//label[contains(text(),'Internal Delivery Cost')]/../..//input");

        //Methods
        public async Task EnterBusinessVolume(string businessVolume)
        {
            await BusinessVolumeTextBox.FillAsync(businessVolume);
            await BusinessVolumeTextBox.PressAsync("Enter");
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task EnterLicenseCost(string licenseCost)
        {
            await LicenseCostTextBox.FillAsync(licenseCost);
            await LicenseCostTextBox.PressAsync("Enter");
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task EnterThirdPartyDeliveryCost(string thirdPartyDeliveryCost)
        {
            await ThirdPartyDeliveryCostTextBox.FillAsync(thirdPartyDeliveryCost);
            await ThirdPartyDeliveryCostTextBox.PressAsync("Enter");
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task EnterInternalDeliveryCost(string internalDeliveryCost)
        {
            await InternalDeliveryCostTextBox.FillAsync(internalDeliveryCost);
            await InternalDeliveryCostTextBox.PressAsync("Enter");
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task ClickNextButtonFromConfigureMASPage(string pagePlacementText)
        {
            await _controls.WaitForPageAppears(pagePlacementText);
            await _controls.NextButton(pagePlacementText).ClickAsync();    
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}
