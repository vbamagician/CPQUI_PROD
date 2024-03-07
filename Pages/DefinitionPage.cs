using CPQUI.Controls;
using Microsoft.Playwright;
using NUnit.Framework;

namespace CPQUI.Pages
{
    internal class DefinitionPage
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        // Constructor
        public DefinitionPage(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        // Common Properties
        private ILocator PopupWindowCloseButton => _page.GetByRole(AriaRole.Button, new() { Name = "" });
        private ILocator TimeAndMateiralRadioButton => _page.GetByText("Time & Material");
        private ILocator ContractDurationTextBox => _page.Locator("//label[contains(text(),'Contract Duration (months)')]/../..//input");

        //*****************************************************************************************************************
        // Properties of Microsoft Agreement Services 
        //*****************************************************************************************************************
        private ILocator ManagedLSPPackCheckBox => _page.Locator("//span[text()='Pack Managed LSP']/../../td[1]/label\r\n");


        //*****************************************************************************************************************
        // Properties of Managed UC
        //*****************************************************************************************************************
        private ILocator ManagedUCVoiceForOptionalServicesRadioButton => _page.Locator("//label[contains(text(),'Managed Unified Communication Voice or Teams Essentials?')]/../../div[2]/div[1]/ul/li[1]/label\r\n");
        private ILocator YesfoIsVoiceInfrastructureSupportRequiredRadioButton => _page.Locator("//label[contains(text(),'Is Voice Infrastructure support required?')]/../..//label[contains(text(),'Yes')]");
        private ILocator NoForIsCallRouteRequiredRadioButton => _page.Locator("//label[contains(text(),'Is Call Route required?')]/../..//label[contains(text(),'No')]");




        //  MM    MM  EEEEEE  TTTTTT  HH    HH  OOOOO  DDDDD    SSSSSS
        //  MMM  MMM  EE        TT    HH    HH OO   OO DD   DD  SS
        //  MM MM MM  EEEE      TT    HHHHHHHH OO   OO DD   DD  SSSSSS
        //  MM    MM  EE        TT    HH    HH OO   OO DD   DD      SS
        //  MM    MM  EEEEEE    TT    HH    HH  OOOOO  DDDDDD   SSSSSS



        //*****************************************************************************************************************
        // Methods of Managed UC
        //*****************************************************************************************************************
        public async Task SelectOptionManagedUnifiedCommunicationsVoiceForOptionalServices()
        {
            await ManagedUCVoiceForOptionalServicesRadioButton.ClickAsync();
        }

        public async Task SelectOptionYesForIsVoiceInfrastructureSupportRequired()
        {
            await YesfoIsVoiceInfrastructureSupportRequiredRadioButton.ClickAsync();
        }

        public async Task SelectOptionNoForIsCallRouteRequired()
        {
            await NoForIsCallRouteRequiredRadioButton.ClickAsync();
        }



        //*****************************************************************************************************************
        // Methods of Microsoft Agreement Services 
        //*****************************************************************************************************************
        public async Task SelectPackManagedLSPCheckbox()
        {
            await ManagedLSPPackCheckBox.ClickAsync();
        }

        //*****************************************************************************************************************
        // Common Methods
        //*****************************************************************************************************************
        public async Task ClosePopupWindow()
        {
            await PopupWindowCloseButton.ClickAsync();
        }

        public async Task ChooseTimeMaterialFromTypeOfContractQuestion()
        {
            await TimeAndMateiralRadioButton.ClickAsync();
        }

        public async Task EnterContractDurationInMonths(string contractDurationInMonths)
        {
            await ContractDurationTextBox.FillAsync(contractDurationInMonths);
        }

        public async Task ClickOnNextButtonFromDefinitionPage(string pagePlacementText)
        {
            await _controls.WaitForPageAppears(pagePlacementText);

            // Take Screenshot 
            await _controls.TakeScreenShot();

            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}
