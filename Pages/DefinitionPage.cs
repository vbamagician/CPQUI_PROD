using CPQUI.Controls;
using Microsoft.Playwright;

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


        //  MM    MM  EEEEEE  TTTTTT  HH    HH  OOOOO  DDDDD    SSSSSS
        //  MMM  MMM  EE        TT    HH    HH OO   OO DD   DD  SS
        //  MM MM MM  EEEE      TT    HHHHHHHH OO   OO DD   DD  SSSSSS
        //  MM    MM  EE        TT    HH    HH OO   OO DD   DD      SS
        //  MM    MM  EEEEEE    TT    HH    HH  OOOOO  DDDDDD   SSSSSS

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
            await _controls.NextButton.ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}
