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
    internal class CustomerPricingPage
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        //Constructor
        public CustomerPricingPage(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        //Common Properties
       
        //Properties of Security Posture Assess. Example 
        private ILocator PlanOptions => _page.GetByText("Days");

        //Methods of Security Posture Assess. Example 
        public async Task IChoosePlanInDays()
        {
            await PlanOptions.ClickAsync();
        }

        //Common Methods
        public async Task ClickOnNextButtonFromCustomerPricingPage(string pagePlacementText)
        {
            await _controls.WaitForPageAppears(pagePlacementText);
            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}
