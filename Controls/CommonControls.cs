using Microsoft.Playwright;

namespace CPQUI.Controls
{
    internal class CommonControls
    {
        private readonly IPage _page;

        //Constructor
        public CommonControls(IPage page)
        {
            _page = page;
            _page.SetDefaultTimeout(70000);
        }

        // Private Properties
        private ILocator TransitionButton(string pagePlacementText) => _page.Locator($"//div[contains(@class, 'heap-{pagePlacementText}')]/div[1]/div[1]/button");
        private ILocator LoadingScreen => _page.Locator("#ContentPlaceHolderBody_ctl02_ctl02");

        // Public Properties 
        public ILocator NextButton(string pagePlacementText) => _page.Locator($"//div[contains(@class,'heap-{pagePlacementText}')]//button[contains(text(),'Next')]");
        public ILocator FinishButton(string pagePlacementText) => _page.Locator($"//div[contains(@class,'heap-{pagePlacementText}')]//button[contains(text(),'Finish')]");

        // Public properties based on Cousine Label or Header
        public ILocator LocateTextBoxByCousineLabel(string question) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//input");
        public ILocator LocateRadioButtonByCousineLable(string question, string optionString) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//label[contains(text()[normalize-space()],'{optionString}')]");
        public ILocator LocateDropdownByCousineLabel(string question) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//select");
        public ILocator LocateTextBoxBasedOnPrecedingHeader(string header) => _page.Locator($"//*[contains(text(),'{header}')]/../../../../following::div[1]//input");
        public ILocator LocateTextAreaByCousineLabel(string question) => _page.Locator($"//label[contains(text(),'{question}')]/../..//textarea");

        // Public Methods
        public async Task WaitForPageAppears(string pagePlacementText)
        {
            int timer = 0;
            do
            {
                if (timer > 50000)
                    break;
                timer += 1000;
                Thread.Sleep(1000);
            } while (await TransitionButton(pagePlacementText).IsHiddenAsync());
        }

        public async Task WaitForLoadingScreenToDisappear()
        {
            int timer = 0;
            do
            {
                if (timer > 50000)
                    break;
                timer += 1000;
                Thread.Sleep(1000);
            } while (await LoadingScreen.IsVisibleAsync());
        }

        public async Task WaitForElementUntilItIsVisible(ILocator element, int waitFor)
        {
            int timer = 0;
            do
            {
                if (timer > waitFor)
                    break;
                timer += 1000;
                Thread.Sleep(1000);
            } while (await element.IsHiddenAsync());
        }

        public async Task<bool> IsElementAvailable(ILocator element, int waitFor)
        {
            // Initialize a counter for the timeout
            int timer = 0;

            // Repeatedly check the element's visibility until it's available or the timeout is reached
            do
            {
                if (timer > waitFor)
                {
                    // Timeout exceeded, element is not available
                    break;
                }

                // Delay execution for one second
                Thread.Sleep(1000);
                timer += 1000;

                // Check if the element is visible
                if (await element.IsVisibleAsync())
                {
                    // Element is available, return true
                    return true;
                }
            } while (await element.IsHiddenAsync());

            // Timeout reached or element is hidden, return false
            return false;
        }

        public void HoldThread(int sleepingTime)
        {
            Thread.Sleep(sleepingTime);
        }
    }
}