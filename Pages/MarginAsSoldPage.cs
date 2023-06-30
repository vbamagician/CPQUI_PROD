using CPQUI.Controls;
using Microsoft.Playwright;

namespace CPQUI.Pages
{
    internal class MarginAsSoldPage
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        // Constructor
        public MarginAsSoldPage(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        // Common Properties
        
        // Common Methods
        public async Task ClickOnNextButtonFromMarginAsSoldPage(string pagePlacementText)
        {
            await _controls.WaitForPageAppears(pagePlacementText);
            await _controls.NextButton.ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task ClickOnFinishBttonFromMarginAsSoldPage(string pagePlacementText)
        {
            await _controls.WaitForPageAppears(pagePlacementText);
            await _controls.FinishButton.ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}
