using CPQUI.Controls;
using Microsoft.Playwright;

namespace CPQUI.Pages
{
    internal class SolutionsPage
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        // Constructor
        public SolutionsPage(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        // Properties
        private ILocator ConfigureButton => _page.Locator("//button[text()='Configure Now']");
        
        // Methods
        public async Task SelectSolution(string solution)
        {
            var myButton = _page.Locator($"//span[contains(text(),'{solution}')]/../../td/button[text()='Get Contract']");
            await myButton.ClickAsync();
        }  

        public async Task SelectSpecificSolution(string solution)
        {
            var myButton = _page.Locator($"//span[text()='{solution}']/../../td/button[text()='Get Contract']");
            await myButton.ClickAsync();
        }

        public async Task ClickOnConfigureButton()
        {
            // Check if the Configure button is available within 30 seconds
            bool isElementPresent = await _controls.IsElementAvailable(ConfigureButton, 30000);

            if (isElementPresent)
            {
                // If the button is available, click on it
                await ConfigureButton.ClickAsync();
            }
        }
    }
}
