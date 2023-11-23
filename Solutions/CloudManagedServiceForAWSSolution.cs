using CPQUI.Controls;
using Microsoft.Playwright;

namespace CPQUI.Solutions
{
    internal class CloudManagedServiceForAWSSolution
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        //===============================================================================================================================
        // Contructor
        //===============================================================================================================================

        public CloudManagedServiceForAWSSolution(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        //===============================================================================================================================
        // Private Properties
        //===============================================================================================================================
        private ILocator LocatorForEssentialRadioButton(string choosenService) => _page.Locator($"//label[text()='{choosenService}']"); 

        //===============================================================================================================================
        // Public Methods
        //===============================================================================================================================

        public async Task SelectServiceForCloudManagedServicesForAWS(string choosenService)
        {
            await LocatorForEssentialRadioButton(choosenService).ClickAsync();
        }

        public async Task EnterValueInTextBoxBasedOnQuestion(string question, string answer)
        {
            await _controls.LocateTextBoxByCousineLabel(question).FillAsync(answer);
        }

        public async Task ChooseRadioButtonBasedOnQuestion(string question, string optionString)
        {
            await _controls.LocateRadioButtonByCousineLable(question, optionString).ClickAsync();
        }

        public async Task ChooseDropDownItemBasedOnQuestion(string question, string optionString)
        {
            await _controls.LocateDropdownByCousineLabel(question).SelectOptionAsync(new[] { optionString });
        }

        //===============================================================================================================================
        // Common Methods
        //===============================================================================================================================


        public async Task ClickOnNextButtonPage(string pagePlacementText)
        {
            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

    }
}
