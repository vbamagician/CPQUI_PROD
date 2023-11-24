using CPQUI.Controls;
using Microsoft.Playwright;

namespace CPQUI.Solutions
{
    internal class OracleAdvisoryServicesSolution
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        //===============================================================================================================================
        // Contructor
        //===============================================================================================================================

        public OracleAdvisoryServicesSolution(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        //===============================================================================================================================
        // Public Properties
        //===============================================================================================================================

        public async Task ChooseRadioButtonBasedOnQuestion(string question, string optionString)
        {
            await _controls.LocateRadioButtonByCousineLable(question, optionString).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task EnterValueInTextBoxBasedOnHeader(string header, string answer)
        {
            await _controls.LocateTextBoxBasedOnPrecedingHeader(header).FillAsync(answer);
        }

        public async Task EnterValueInTextAreaBasedOnQuestion(string question, string answer)
        {
            await _controls.LocateTextAreaByCousineLabel(question).FillAsync(answer);
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
