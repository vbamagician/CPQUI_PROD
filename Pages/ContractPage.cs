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

        private ILocator NewContractButton => _page.Locator("#ContentPlaceHolderBody_ctl01_knpyt__3_1XD7ZrJPv9Iqz1Ln_1zBGX4kr9x0_1pjeq5Mlm7WdsmA_2__kk");
        private ILocator SelectAccountTextBox => _page.Locator("#ContentPlaceHolderBody_ctl01_knpyt__2t_12vi2aKcvwdNJvWnzV4yQt4zQOzdFl9CD8T5iKN_3s_2__kk");
        private ILocator IConfirmButton => _page.Locator("//button[contains(text(),'I Confirm')]");
        
        //Methods

        public async Task ConfigureClientDetailsForNewContract()
        {
            await SelectAccountTextBox.FillAsync("walmart");
            await _page.GetByRole(AriaRole.Textbox).PressAsync("Enter");
            await _page.GetByRole(AriaRole.Row, new() { Name = "00001614 Walmart 1940 Argentia Rd, Ontario L5N 1P9 Canada" }).Locator("label span").ClickAsync();
            await _page.GetByRole(AriaRole.Button, new() { Name = "Do you want to continue without an Opportunity?" }).ClickAsync();
            await _page.Locator("input[name=\"ctl00\\$ContentPlaceHolderBody\\$ctl01\\$knpyt__wQjyG9LwlR6CaqhbL0prnJO7pc8HHJIq3rgILt6Dn00_2__kk\"]").ClickAsync();
            await _page.Locator("input[name=\"ctl00\\$ContentPlaceHolderBody\\$ctl01\\$knpyt__wQjyG9LwlR6CaqhbL0prnJO7pc8HHJIq3rgILt6Dn00_2__kk\"]").FillAsync("Test1");
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
