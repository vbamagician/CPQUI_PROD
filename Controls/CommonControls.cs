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

        // Public properties based on Cousine Label 
        public ILocator LocateTextBoxByCousineLabel(string question) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//input");
        public ILocator LocateRadioButtonByCousineLable(string question, string optionString) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//label[contains(text()[normalize-space()],'{optionString}')]");
        public ILocator LocateDropdownByCousineLabel(string question) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//select");

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

        public void HoldThread(int sleepingTime)
        {
            Thread.Sleep(sleepingTime);
        }
    }
}