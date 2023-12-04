using Microsoft.Playwright;
using NUnit.Framework.Internal.Execution;
using System.Reflection.PortableExecutable;

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

        //Button
        public ILocator LocateButtonByCaption(string buttonCaption) => _page.Locator($"//button[contains(text()[normalize-space()],'{buttonCaption}')]");
        public ILocator LocateButtonByCaptionAndCousineSpanText(string spanText, string buttonCaption) => _page.Locator($"//span[contains(text()[normalize-space()],'{spanText}')]/../..//button[contains(text()[normalize-space()],'{buttonCaption}')]");
        public ILocator LocateButtonByCaptionAndParentIdentifier(string buttonCaption, string parentClassName) => _page.Locator($"//div[contains(@class[normalize-space()],'{parentClassName}')]//button[contains(text()[normalize-space()],'{buttonCaption}')]");

        //TextBoxes
        public ILocator LocateTextBoxByCousineLabel(string question) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//input");
        public ILocator LocateTextBoxByCousineLabelAndRepeatationIndex(string question, string repeatationIndex) => _page.Locator($"(//label[contains(text()[normalize-space()],'{question}')]/../..//input)[{repeatationIndex}]");
        public ILocator LocateTextBoxBasedOnPrecedingHeader(string header) => _page.Locator($"//*[contains(text(),'{header}')]/../../../../following::div[1]//input");
        public ILocator LocateTextAreaByCousineLabel(string question) => _page.Locator($"//label[contains(text(),'{question}')]/../..//textarea");

        //Radio Buttons
        public ILocator LocateRadioButtonByText(string radioButtonText) => _page.Locator($"//label[text()='{radioButtonText}']");
        public ILocator LocateRadioButtonByCousineLable(string question, string optionString) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//label[contains(text()[normalize-space()],'{optionString}')]");
        
        //Dropdown
        public ILocator LocateDropdownByCousineLabel(string question) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//select");

        //CheckBox
        public ILocator LocateCheckBoxByCousineTableCell(string tableIndex, string tableCellText) => _page.Locator($"(//table)[{tableIndex}]//*[contains(text()[normalize-space()],'{tableCellText}')]/../..//label");
        public ILocator LocateCheckBoxBasedOnPrecedingHeader(string header, string checkBoxText) => _page.Locator($"//*[contains(text()[normalize-space()],'{header}')]/../../../../following::div[1]//label[contains(text()[normalize-space()],'{checkBoxText}')]");
            
        // Public Methods
        public async Task ClickOnButtonByCaptionAndParentIdentifier(string buttonCaption, string parentClassName)
        {
            await LocateButtonByCaptionAndParentIdentifier(buttonCaption, parentClassName).ClickAsync();
            await WaitForLoadingScreenToDisappear();
        }

        public async Task ClickOnButtonByCaptionIfItIsFoundWithinTimeRangeElseSkipElement(string buttonCaption, int waitFor)
        {
            // Check if the Configure button is available within 30 seconds
            bool isElementPresent = await IsElementAvailable(LocateButtonByCaption(buttonCaption), waitFor * 1000);

            if (isElementPresent)
            {
                // If the button is available, click on it
                await LocateButtonByCaption(buttonCaption).ClickAsync();
            }
        }

        public async Task ClickOnButtonbyCaptionReferencedFromSpanElement(string spanText, string buttonCaption)
        { 
            await LocateButtonByCaptionAndCousineSpanText(spanText, buttonCaption).ClickAsync();
        }

        public async Task SetCheckboxStateByAdjacentTableCell(string tableIndex, string tableCellText, string checkBoxBehaviour)
        {
            await LocateCheckBoxByCousineTableCell(tableIndex, tableCellText).ClickAsync();
            if (checkBoxBehaviour == "synchronous")
            {
                await WaitForLoadingScreenToDisappear();
            }
        }

        public async Task SetCheckBoxBasedOnHeaderText(string header, string checkBoxText)
        {
            await LocateCheckBoxBasedOnPrecedingHeader(header, checkBoxText).ClickAsync();
        }

        public async Task ClickOnButtonByCaption(string buttonCaption)
        {
            await LocateButtonByCaption(buttonCaption).ClickAsync();
        }

        public async Task EnterValueInTextBoxBasedOnQuestion(string question, string answer)
        {
            await LocateTextBoxByCousineLabel(question).FillAsync(answer);
        }

        public async Task ChooseRadioButtonByText(string radioButtonText)
        {
            await LocateRadioButtonByText(radioButtonText).ClickAsync();
            await WaitForLoadingScreenToDisappear();
        }

        public async Task ChooseRadioButtonBasedOnQuestion(string question, string optionString)
        {
            await LocateRadioButtonByCousineLable(question, optionString).ClickAsync();
            await WaitForLoadingScreenToDisappear();
        }

        public async Task ChooseDropDownItemBasedOnQuestion(string question, string optionString)
        {
            await LocateDropdownByCousineLabel(question).SelectOptionAsync(new[] { optionString });
        }

        public async Task EnterValueInTextBoxBasedOnHeader(string header, string answer)
        {
            await LocateTextBoxBasedOnPrecedingHeader(header).FillAsync(answer);
        }

        public async Task EnterValueInTextBoxBasedOnHeaderAndPressKey(string header, string answer, string keyToPress)
        {
            ILocator textBox = LocateTextBoxBasedOnPrecedingHeader(header);

            await textBox.FillAsync(answer);

            if (keyToPress != "Nothing")
            {
                await textBox.PressAsync(keyToPress);
            }
        }

        public async Task EnterValueInTextBoxBasedOnQuestionAndRepeatationIndex(string answer, string question, string repeatationIndex, string keyToPress)
        {
            ILocator textBox = LocateTextBoxByCousineLabelAndRepeatationIndex(question, repeatationIndex);

            await textBox.FillAsync(answer);

            if (keyToPress != "Nothing")
            {
                await textBox.PressAsync(keyToPress);
            }
        }

        public async Task EnterValueInTextBoxBasedOnQuestionAndPressKey(string answer, string question, string keyToPress)
        {
            ILocator textBox = LocateTextBoxByCousineLabel(question);

            await textBox.FillAsync(answer);

            if (keyToPress != "Nothing")
            {
                await textBox.PressAsync(keyToPress);
            }
        }

        public async Task EnterValueInTextAreaBasedOnQuestion(string question, string answer)
        {
            await LocateTextAreaByCousineLabel(question).FillAsync(answer);
        }

        public async Task ClickOnNextButtonPage(string pagePlacementText)
        {
            await NextButton(pagePlacementText).ClickAsync();
            await WaitForLoadingScreenToDisappear();
        }

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