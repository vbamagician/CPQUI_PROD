using CPQUI.Controls;
using Microsoft.Playwright;

namespace CPQUI.Pages
{
    internal class ContactsPage
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        //Constructor
        public ContactsPage(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        //Common Properties
        private ILocator DocumentTypeButton => _page.Locator("//label[contains(text(),'Document Type:')]/../..//select");
                                                              
        //Customer's Contact Elements
        private ILocator AddAuthorizedContactButton => _page.Locator("(//button[contains(text(),'Add')])[1]");
        private ILocator SaveAuthorizedContactButton => _page.Locator("//button[normalize-space(text())='Save']");

        //SoftwareONE Contact Elements
        private ILocator AddSWOContactButton => _page.Locator("(//button[contains(text(),'Add')])[2]");
        private ILocator SWOContactNameTextBox => _page.Locator("//label[contains(text(),'Contact name')]//../..//input");
        private ILocator SWOContactJobTitleTextBox => _page.Locator("//label[contains(text(),'Job title')]//../..//input");
        private ILocator SWOContactTelephoneTextBox => _page.Locator("//label[contains(text(),'Telephone number')]//../..//input");
        private ILocator SWOContactEmailTextBox => _page.Locator("//label[contains(text(),'Email')]//../..//input");
        private ILocator SaveSWOContactButton => _page.Locator("//button[normalize-space(text())='Save']");

        //Common Methods
        public async Task AddAuthorizedContacts(string pagePlacementText)
        {
            await _controls.WaitForPageAppears(pagePlacementText);
            await AddAuthorizedContactButton.ClickAsync();
            await SaveAuthorizedContactButton.ClickAsync();
        }

        public async Task AddSoftwareoneContacts()
        {
            await AddSWOContactButton.ClickAsync();
            await SWOContactNameTextBox.FillAsync("Kamal Bharakhda");
            await SWOContactJobTitleTextBox.FillAsync("Software Engineer");
            await SWOContactTelephoneTextBox.FillAsync("9328093207");
            await SWOContactEmailTextBox.FillAsync("kamal.bharakhda@softwareone.com");
            await SaveSWOContactButton.ClickAsync();
        }

        public async Task SelectDocumentTypeAsPDF()
        {
            await DocumentTypeButton.SelectOptionAsync(new[] { "PDF" });
        }

        public async Task ClickOnFinishButtonFromContactsPage(string pagePlacementText)
        {
            await _controls.WaitForPageAppears(pagePlacementText);
            await _controls.FinishButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}
