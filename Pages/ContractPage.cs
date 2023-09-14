using CPQUI.Controls;
using Microsoft.Playwright;

namespace CPQUI.Pages
{
    internal class ContractPage
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        //Constructor
        public ContractPage(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        //Propertie

        private ILocator NewContractButton => _page.Locator("//button[contains(text(),'New Contract')]");
        private ILocator SelectAccountTextBox => _page.Locator("//*[contains(text(),'Select an Account')]/../../../../..//div[contains(@class,'HomepageSearchBox')]//input");
        private ILocator IConfirmButton => _page.Locator("//button[contains(text(),'I Confirm')]");
        
        //Methods

        public async Task ConfigureClientDetailsForNewContract()
        {
            await SelectAccountTextBox.FillAsync("walmart");
            await _page.GetByRole(AriaRole.Textbox).PressAsync("Enter");
            await _page.GetByRole(AriaRole.Row, new() { Name = "00001614 Walmart 1940 Argentia Rd, Ontario L5N 1P9 Canada" }).Locator("label span").ClickAsync();
            await _page.GetByRole(AriaRole.Button, new() { Name = "Do you want to continue without an Opportunity?" }).ClickAsync();
            await _page.Locator("//label[contains(text(),'Draft topic:')]/../..//input").FillAsync("Test1");
            await _page.GetByRole(AriaRole.Row, new() { Name = " Dwayne \"The Rock\" Johnson Actor   " }).Locator("label span").ClickAsync();

            //Wait until loading screen disappear
            await _controls.WaitForLoadingScreenToDisappear();
            await IConfirmButton.ClickAsync();
        }

        public async Task ClickOnNewContractButton()
        {
            await NewContractButton.ClickAsync();
        }
    }
}
