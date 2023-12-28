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

        //-------------------------------------------------------------------------------
        //Button
        //-------------------------------------------------------------------------------
        public ILocator LocateButtonByCaption(string buttonCaption) => _page.Locator($"//button[contains(text()[normalize-space()],'{buttonCaption}')]");
        public ILocator LocateButtonByCaptionAndCousineSpanText(string spanText, string buttonCaption) => _page.Locator($"//span[contains(text()[normalize-space()],'{spanText}')]/../..//button[contains(text()[normalize-space()],'{buttonCaption}')]");
        public ILocator LocateButtonByCaptionAndParentIdentifier(string buttonCaption, string parentClassName) => _page.Locator($"//div[contains(@class[normalize-space()],'{parentClassName}')]//button[contains(text()[normalize-space()],'{buttonCaption}')]");

        //-------------------------------------------------------------------------------
        //TextBoxes
        //-------------------------------------------------------------------------------
        public ILocator LocateTextBoxByCousineLabel(string question) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//input");
        public ILocator LocateTextBoxByCousineLabelAndRepeatationIndex(string question, string repeatationIndex) => _page.Locator($"(//label[contains(text()[normalize-space()],'{question}')]/../..//input)[{repeatationIndex}]");
        public ILocator LocateTextBoxBasedOnPrecedingHeader(string header) => _page.Locator($"//*[contains(text(),'{header}')]/../../../../following::div[1]//input");
        public ILocator LocateTextAreaByCousineLabel(string question) => _page.Locator($"//label[contains(text(),'{question}')]/../..//textarea");

        //-------------------------------------------------------------------------------
        //Radio Buttons
        //-------------------------------------------------------------------------------
        public ILocator LocateRadioButtonByText(string radioButtonText) => _page.Locator($"//label[text()='{radioButtonText}']");
        public ILocator LocateRadioButtonByCousineLable(string question, string optionString) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//label[contains(text()[normalize-space()],'{optionString}')]");

        //-------------------------------------------------------------------------------
        //Dropdown
        //-------------------------------------------------------------------------------
        public ILocator LocateDropdownByCousineLabel(string question) => _page.Locator($"//label[contains(text()[normalize-space()],'{question}')]/../..//select");

        //-------------------------------------------------------------------------------
        //CheckBox
        //-------------------------------------------------------------------------------
        public ILocator LocateCheckBoxByCousineTableCell(string tableIndex, string tableCellText) => _page.Locator($"(//table)[{tableIndex}]//*[contains(text()[normalize-space()],'{tableCellText}')]/../..//label");
        public ILocator LocateCheckBoxBasedOnPrecedingHeader(string header, string checkBoxText) => _page.Locator($"//*[contains(text()[normalize-space()],'{header}')]/../../../../following::div[1]//label[contains(text()[normalize-space()],'{checkBoxText}')]");

        // Public Methods

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Buttons
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This procedure clicks on a button element based on its caption.
        /// </summary>
        /// <param name="buttonCaption">The text displayed on the button.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task ClickOnButtonByCaption(string buttonCaption)
        {
            // Locate the button by searching for the element containing the specified caption.
            ILocator button = LocateButtonByCaption(buttonCaption);

            // Click on the button.
            await button.ClickAsync();
        }


        /// <summary>
        /// This procedure clicks on a button element based on its caption and its parent element's class name.
        /// </summary>
        /// <param name="buttonCaption">The text displayed on the button.</param>
        /// <param name="parentClassName">The class name of the button's parent element.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task ClickOnButtonByCaptionAndParentIdentifier(string buttonCaption, string parentClassName)
        {
            // Locate the button by searching for the element containing the specified caption
            // within a parent element with the specified class name.
            ILocator button = LocateButtonByCaptionAndParentIdentifier(buttonCaption, parentClassName);

            // Click on the button.
            await button.ClickAsync();

            // Wait for the loading screen to disappear after clicking the button.
            await WaitForLoadingScreenToDisappear();

            /* There has been a recurring observation over the past few weeks where the data grid on the CPQ page 
             * necessitates a manual refresh to display updated information. Notably, certain pages, such as the 
             * Cost pages, solely rely on data grids that require refreshing or updating by clicking on the next 
             * button. Consequently, the initial click on the next button triggers the data grid update, and to 
             * navigate away from the page, a subsequent click is required.
             */

            /* To handle above isssue, I want to wait for a few second and check agian if the same element is 
             * visible or not. If visible then click again. Probably, 5 second is perfectly okay to wait. 
             */
            this.HoldThread(3000);

            if (await button.IsVisibleAsync() && buttonCaption != "Finish")
            {
                await button.ClickAsync();
            }
        }


        /// <summary>
        /// This procedure attempts to click on a button element based on its caption within a specified time range. If the element is not found within the time range, the procedure skips it.
        /// </summary>
        /// <param name="buttonCaption">The text displayed on the button.</param>
        /// <param name="waitFor">The maximum amount of time to wait for the element to become available, in seconds.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task ClickOnButtonByCaptionIfItIsFoundWithinTimeRangeElseSkipElement(string buttonCaption, int waitFor)
        {
            // Check if the button is available within the specified time range.
            bool isElementPresent = await IsElementAvailable(LocateButtonByCaption(buttonCaption), waitFor * 1000);

            // If the button is available, click on it.
            if (isElementPresent)
            {
                await LocateButtonByCaption(buttonCaption).ClickAsync();
            }
            else
            {
                // Log that the button was not found within the time range.
                Console.WriteLine($"Button '{buttonCaption}' was not found within {waitFor} seconds, skipping element.");
            }
        }


        /// <summary>
        /// This procedure clicks on a button element based on its caption, which is referenced from a span element containing the specified text.
        /// </summary>
        /// <param name="spanText">The text displayed in the span element that references the button.</param>
        /// <param name="buttonCaption">The text displayed on the button.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task ClickOnButtonbyCaptionReferencedFromSpanElement(string spanText, string buttonCaption)
        {
            // Locate the button by searching for the element containing the specified caption
            // and ensuring it is a descendant of a span element containing the provided text.
            ILocator button = LocateButtonByCaptionAndCousineSpanText(spanText, buttonCaption);

            // Click on the button.
            await button.ClickAsync();
        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // CheckBox
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This procedure sets the state of a checkbox based on its position relative to a table cell containing the specified text.
        /// </summary>
        /// <param name="tableIndex">The index of the table element.</param>
        /// <param name="tableCellText">The text displayed within the table cell adjacent to the checkbox.</param>
        /// <param name="checkBoxBehaviour">Specifies whether to wait for a loading screen to disappear after checking the box ("synchronous") or not ("asynchronous").</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task SetCheckboxStateByAdjacentTableCell(string tableIndex, string tableCellText, string checkBoxBehaviour)
        {
            // Locate the checkbox based on its position next to a table cell containing the specified text.
            ILocator checkBox = LocateCheckBoxByCousineTableCell(tableIndex, tableCellText);

            // Click on the checkbox to change its state.
            await checkBox.ClickAsync();

            // Optionally wait for the loading screen to disappear after clicking the checkbox.
            if (checkBoxBehaviour == "synchronous")
            {
                await WaitForLoadingScreenToDisappear();
            }
        }


        /// <summary>
        /// This procedure sets the state of a checkbox based on the text of a preceding header element.
        /// </summary>
        /// <param name="header">The text displayed in the header element preceding the checkbox.</param>
        /// <param name="checkBoxText">The text displayed on the checkbox label.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task SetCheckBoxBasedOnHeaderText(string header, string checkBoxText)
        {
            // Locate the checkbox based on its position following a header element containing the specified text.
            ILocator checkBox = LocateCheckBoxBasedOnPrecedingHeader(header, checkBoxText);

            // Click on the checkbox to change its state.
            await checkBox.ClickAsync();
        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // TextBox
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This procedure enters a value into a text box based on the text of the label associated with the text box.
        /// </summary>
        /// <param name="question">The text of the label associated with the text box.</param>
        /// <param name="answer">The text to enter into the text box.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task EnterValueInTextBoxBasedOnQuestion(string question, string answer)
        {
            // Locate the text box by searching for the label containing the specified question text.
            ILocator textBox = LocateTextBoxByCousineLabel(question);

            // Enter the specified answer into the text box.
            await textBox.FillAsync(answer);
        }

        /// <summary>
        /// This procedure enters a value into a text box based on the text of the preceding header element.
        /// </summary>
        /// <param name="header">The text displayed in the header element preceding the text box.</param>
        /// <param name="answer">The text to enter into the text box.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task EnterValueInTextBoxBasedOnHeader(string header, string answer)
        {
            // Locate the text box based on its position following a header element containing the specified text.
            ILocator textBox = LocateTextBoxBasedOnPrecedingHeader(header);

            // Enter the specified answer into the text box.
            await textBox.FillAsync(answer);
        }


        /// <summary>
        /// This procedure enters a value into a text box based on the text of the preceding header element and presses a key afterwards.
        /// </summary>
        /// <param name="header">The text displayed in the header element preceding the text box.</param>
        /// <param name="answer">The text to enter into the text box.</param>
        /// <param name="keyToPress">The key to press after entering the text. Use "Nothing" to skip this step.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task EnterValueInTextBoxBasedOnHeaderAndPressKey(string header, string answer, string keyToPress)
        {
            // Locate the text box based on its position following a header element containing the specified text.
            ILocator textBox = LocateTextBoxBasedOnPrecedingHeader(header);

            // Enter the specified answer into the text box.
            await textBox.FillAsync(answer);

            // If a key is specified, press it after entering the text.
            if (keyToPress != "Nothing")
            {
                await textBox.PressAsync(keyToPress);
            }
        }


        /// <summary>
        /// This procedure enters a value into a text box based on a question label, a repetition index, and presses a key afterwards.
        /// </summary>
        /// <param name="answer">The text to enter into the text box.</param>
        /// <param name="question">The text of the label associated with the text box.</param>
        /// <param name="repeatationIndex">An index used to identify a specific text box when multiple elements share the same question label.</param>
        /// <param name="keyToPress">The key to press after entering the text. Use "Nothing" to skip this step.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task EnterValueInTextBoxBasedOnQuestionAndRepeatationIndex(string answer, string question, string repeatationIndex, string keyToPress)
        {
            // Locate the text box by searching for the label containing the specified question text and repetition index.
            ILocator textBox = LocateTextBoxByCousineLabelAndRepeatationIndex(question, repeatationIndex);

            // Enter the specified answer into the text box.
            await textBox.FillAsync(answer);

            // If a key is specified, press it after entering the text.
            if (keyToPress != "Nothing")
            {
                await textBox.PressAsync(keyToPress);
            }
        }

        /// <summary>
        /// This procedure enters a value into a text box based on a question label and presses a key afterwards.
        /// </summary>
        /// <param name="answer">The text to enter into the text box.</param>
        /// <param name="question">The text of the label associated with the text box.</param>
        /// <param name="keyToPress">The key to press after entering the text. Use "Nothing" to skip this step.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task EnterValueInTextBoxBasedOnQuestionAndPressKey(string answer, string question, string keyToPress)
        {
            // Locate the text box by searching for the label containing the specified question text.
            ILocator textBox = LocateTextBoxByCousineLabel(question);

            // Enter the specified answer into the text box.
            await textBox.FillAsync(answer);

            // If a key is specified, press it after entering the text.
            if (keyToPress != "Nothing")
            {
                await textBox.PressAsync(keyToPress);
            }
        }

        /// <summary>
        /// This procedure enters a value into a 'textarea' element based on the text of the label associated with the text area.
        /// </summary>
        /// <param name="question">The text of the label associated with the text area.</param>
        /// <param name="answer">The text to enter into the text area.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task EnterValueInTextAreaBasedOnQuestion(string question, string answer)
        {
            // Locate the text area by searching for the label containing the specified question text.
            ILocator textArea = LocateTextAreaByCousineLabel(question);

            // Enter the specified answer into the text area.
            await textArea.FillAsync(answer);
        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Radio Button
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This procedure selects a radio button based on the text displayed on the radio button label.
        /// </summary>
        /// <param name="radioButtonText">The text displayed on the radio button label.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task ChooseRadioButtonByText(string radioButtonText)
        {
            // Locate the radio button by searching for the element containing the specified text.
            ILocator radioButton = LocateRadioButtonByText(radioButtonText);

            // Click on the radio button to select it.
            await radioButton.ClickAsync();

            // Wait for the loading screen to disappear after clicking the radio button.
            await WaitForLoadingScreenToDisappear();
        }


        /// <summary>
        /// This procedure selects a radio button based on the text of the label associated with the question and the specified option string.
        /// </summary>
        /// <param name="question">The text of the label associated with the question.</param>
        /// <param name="optionString">The text displayed on the radio button label representing the desired option.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task ChooseRadioButtonBasedOnQuestion(string question, string optionString)
        {
            // Locate the radio button by searching for the label containing the specified question text and matching the option string.
            ILocator radioButton = LocateRadioButtonByCousineLable(question, optionString);

            // Click on the radio button to select it.
            await radioButton.ClickAsync();

            // Wait for the loading screen to disappear after clicking the radio button.
            await WaitForLoadingScreenToDisappear();
        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // DropDown
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This procedure selects an item from a dropdown menu based on the text of the label associated with the dropdown and the specified option string.
        /// </summary>
        /// <param name="question">The text of the label associated with the dropdown.</param>
        /// <param name="optionString">The text of the option to be selected from the dropdown menu.</param>
        /// <returns>A Task object representing the asynchronous operation.</returns>
        public async Task ChooseDropDownItemBasedOnQuestion(string question, string optionString)
        {
            // Locate the dropdown menu by searching for the label containing the specified question text.
            ILocator dropdown = LocateDropdownByCousineLabel(question);

            // Select the option from the dropdown menu.
            await dropdown.SelectOptionAsync(new[] { optionString });
        }


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // Common Methods 
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

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