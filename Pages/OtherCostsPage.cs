using CPQUI.Controls;
using Microsoft.Playwright;

namespace CPQUI.Pages
{
    internal class OtherCostsPage
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        // Constructor
        public OtherCostsPage(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        // Common Properties
        
        // Common Methods 
        public async Task ClickOnNextButtonFromOtherCostsPage(string pagePlacementText)
        {
            await _controls.WaitForPageAppears(pagePlacementText);

            // Take Screenshot 
            await _controls.TakeScreenShot();

            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }  
}
