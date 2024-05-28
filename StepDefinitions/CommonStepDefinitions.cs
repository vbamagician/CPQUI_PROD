using CPQUI.Controls;
using CPQUI.Drivers;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CommonStepDefinitions
    {
        private readonly Driver _driver;
        private readonly CommonControls _commonControls;

        //Delete this when moving to prod
        private readonly string CPQUI_PAGE_LINK = "https://contracts.softwareone.com/";
        private readonly string CPQUI_LOGIN_USERNAME = "helpdesk-scg.global@softwareone.com";
        private readonly string CPQUI_LOGIN_PASSWORD = "CPQ.account1708";

        private CommonStepDefinitions(Driver driver)
        {
            _driver = driver;
            _commonControls = new CommonControls(_driver.Page);
        }

        [Given(@"I navigate to the page using the environment variable ""([^""]*)""")]
        public void GivenINavigateToThePageUsingTheEnvironmentVariable(string pageLinkEnvVariable)
        {
            string? pageLink = Environment.GetEnvironmentVariable("CPQUI_PAGE_LINK");

            //Delete this when moving to prod
            if (pageLink == null)
                _driver.Page.GotoAsync(CPQUI_PAGE_LINK);
            else
                _driver.Page.GotoAsync(pageLink);
        }

        [Given(@"I enter ""([^""]*)"" into the element ""([^""]*)"" of having attribute ""([^""]*)"" having the value ""([^""]*)""")]
        public async Task GivenIEnterIntoTheElementOfHavingAttributeHavingTheValue(string inputString, string element, string attribute, string attributeValue)
        {
            await _commonControls.EnterValueInElementBasedOnAttribute(inputString, element, attribute, attributeValue);
        }


        [Given(@"I enter ""([^""]*)"" from environment into the element ""([^""]*)"" of having attribute ""([^""]*)"" having the value ""([^""]*)""")]
        public async Task GivenIEnterFromEnvironmentIntoTheElementOfHavingAttributeHavingTheValue(string input, string element, string attribute, string attributeValue)
        {
            string? inputString = Environment.GetEnvironmentVariable(input);


            //Delete this when moving to prod
            if (inputString == null)
            {
                switch (input)
                {
                    case "CPQUI_LOGIN_USERNAME":
                        inputString = CPQUI_LOGIN_USERNAME;
                        break;
                    case "CPQUI_LOGIN_PASSWORD":
                        inputString = CPQUI_LOGIN_PASSWORD;
                        break;
                }
            }
            await _commonControls.EnterValueInElementBasedOnAttribute(inputString, element, attribute, attributeValue);
        }

        //===================================================================================================================================
        // Special Element
        //===================================================================================================================================

        [Given(@"I click on the tile having text ""([^""]*)""")]
        public async Task GivenIClickOnTheTileHavingText(string tileText)
        {
            await _commonControls.ClickOnATileFromTable(tileText);
        }

        [Given(@"I click to close the form ""([^""]*)""")]
        public async Task GivenIClickToCloseTheForm(string subformname)
        {
            await _commonControls.ClickOnCloseButtonOfSubForm(subformname);
        }


        //===================================================================================================================================
        // Buttons:
        //      1. I click the button containing the text
        //      2. Solution Card
        //      3. Wait for button upto defined seconds and if button does not found then skip clicking on it. 
        //      4. Click on the button containing text adjacent to table cell.
        //      5. Click on the button based on it's parent class test. Simply NEXT and FINISH button 
        //      6. Click on the button to download the file and save with name
        //      7. Click on the button to upload the file from the specific path 
        //===================================================================================================================================

        //1
        [Given(@"I click the button containing the text ""([^""]*)""")]
        public async Task GivenIClickTheButtonContainingTheText(string buttonCaption)
        {
            await _commonControls.ClickOnButtonByCaption(buttonCaption);
        }

        //2
        [Given(@"I click the ""([^""]*)"" button associated with the reference text ""([^""]*)""")]
        public async Task GivenIClickTheButtonAssociatedWithTheReferenceText(string buttonCaption, string referenceText)
        {
            await _commonControls.ClickOnButtonbyCaptionReferencedFromSpanElement(referenceText, buttonCaption);
        }

        //3
        [Given(@"I click the button containing the text ""([^""]*)"" Only If button found within (.*) seconds else skip")]
        public async Task GivenIClickTheButtonContainingTheTextOnlyIfButtonFoundWithinSecondsElseSkip(string buttonCaption, int timeRangeInSeconds)
        {
            await _commonControls.ClickOnButtonByCaptionIfItIsFoundWithinTimeRangeElseSkipElement(buttonCaption, timeRangeInSeconds);
        }

        //4
        [When(@"I click the button with the text ""([^""]*)"" identified by the parent class ""([^""]*)""")]
        [Given(@"I click the button with the text ""([^""]*)"" identified by the parent class ""([^""]*)""")]
        public async Task GivenIClickTheButtonWithTheTextIdentifiedByTheParentClass(string buttonCaption, string parentClassName)
        {
            await _commonControls.ClickOnButtonByCaptionAndParentIdentifier(buttonCaption, parentClassName);
        }

        //5
        [Given(@"I click the button containing the text ""([^""]*)"" on the adjacent table has text ""([^""]*)""")]
        public async Task GivenIClickTheButtonContainingTheTextOnTheAdjacentTableHasText(string buttonCaption, string tableCellText)
        {
            await _commonControls.ClickOnButtonByCaptionAdjacentTableCell(tableCellText, buttonCaption);
        }

        //6
        [Given(@"I click the button containing the text ""([^""]*)"" Then the file ""([^""]*)"" should be downloaded and saved")]
        public async Task GivenIClickTheButtonContainingTheTextThenTheFileShouldBeDownloadedAndSaved(string buttonCaption, string fileName)
        {
            await _commonControls.ClickOnButtonToDownloadAFile(buttonCaption, fileName);
        }

        //7
        [Given(@"I click the button containing the text ""([^""]*)"" to upload the file ""([^""]*)"" from the path ""([^""]*)""")]
        public async Task GivenIClickTheButtonContainingTheTextToUploadTheFileFromThePath(string buttonCaption, string fileName, string filePath)
        {
            await _commonControls.ClickOnButtonToUploadAFile(buttonCaption, fileName, filePath);    
        }


        //===================================================================================================================================
        // TextBox
        //===================================================================================================================================

        [Given(@"I enter ""([^""]*)"" to the very special textbox that has question ""([^""]*)""")]
        public async Task GivenIEnterToTheVerySpecialTextboxThatHasQuestion(string answer, string question)
        {
            await _commonControls.EnterValueInTextBoxBasedOnQuestion(question, answer);
        }


        [Given(@"I enter ""([^""]*)"" into the textbox for the question ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxForTheQuestion(string answer, string question)
        {
            await _commonControls.EnterValueInTextBoxBasedOnQuestion(question, answer);
        }

        [Given(@"I enter ""([^""]*)"" into the textbox for the question ""([^""]*)"" and press ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxForTheQuestionAndPress(string answer, string question, string keyToPress)
        {
            await _commonControls.EnterValueInTextBoxBasedOnQuestionAndPressKey(answer, question, keyToPress);
            
        }

        [Given(@"I enter ""([^""]*)"" into the textbox with the header labeled ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxWithTheHeaderLabeled(string clientName, string headerText)
        {
            await _commonControls.EnterValueInTextBoxBasedOnHeader(headerText, clientName);
        }

        [Given(@"I enter ""([^""]*)"" into the textbox with the header labeled ""([^""]*)"" and press ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxWithTheHeaderLabeledAndPress(string walmart, string headerText, string keyToPress)
        {
            await _commonControls.EnterValueInTextBoxBasedOnHeaderAndPressKey(headerText, walmart, keyToPress);
        }

        [Given(@"I enter ""([^""]*)"" into the textbox for the question ""([^""]*)"" having repeat index of ""([^""]*)"" and press ""([^""]*)""")]
        public async Task GivenIEnterIntoTheTextboxForTheQuestionHavingRepeatIndexOfAndPress(string answer, string question, string repeatationIndex, string keyToPress)
        {
            await _commonControls.EnterValueInTextBoxBasedOnQuestionAndRepeatationIndex(answer, question, repeatationIndex, keyToPress);
        }
        

        //===================================================================================================================================
        // Radio Buttons
        //===================================================================================================================================

        [Given(@"I choose the radio button option ""([^""]*)"" specifically")]
        public async Task GivenIChooseTheRadioButtonOptionSpecifically(string radioButtonText)
        {
            await _commonControls.ChooseRadioButtonByText(radioButtonText);
        }

        [Given(@"I choose ""([^""]*)"" from the radio button group for the question ""([^""]*)""")]
        public async Task GivenIChooseFromTheRadioButtonGroupForTheQuestion(string optionString, string question)
        {
            await _commonControls.ChooseRadioButtonBasedOnQuestion(question, optionString);
        }

        [Given(@"I choose ""([^""]*)"" from the radio button group for the question ""([^""]*)"" having repeat index of ""([^""]*)""")]
        public async Task GivenIChooseFromTheRadioButtonGroupForTheQuestionHavingRepeatIndexOf(string optionString, string question, string repeatIndex)
        {
            await _commonControls.ChooseRadioButtonBasedOnQuestionAndRepeatationIndex(question,optionString, repeatIndex);
        }


        //===================================================================================================================================
        // DropDown
        //===================================================================================================================================

        [Given(@"I choose ""([^""]*)"" from the dropdown for the question ""([^""]*)""")]
        public async Task GivenIChooseFromTheDropdownForTheQuestion(string optionString, string question)
        {
            await _commonControls.ChooseDropDownItemBasedOnQuestion(question, optionString);
        }



        //===================================================================================================================================
        // CheckBox
        //===================================================================================================================================

        [Given(@"I check the ""([^""]*)"" checkbox based on the adjacent table has index ""([^""]*)"" having cell that has value ""([^""]*)""")]
        public async Task GivenICheckTheCheckboxBasedOnTheAdjacentTableHasIndexHavingCellThatHasValue(string behaviour, string tableIndex, string adjecentCellText)
        {
            await _commonControls.SetCheckboxStateByAdjacentTableCell(tableIndex, adjecentCellText, behaviour);
        }

        [Given(@"I check ""([^""]*)"" checkbox for the header ""([^""]*)""")]
        public async Task GivenICheckCheckboxForTheHeader(string checkBoxText, string header)
        {
            await _commonControls.SetCheckBoxBasedOnHeaderText(header, checkBoxText);
        }

        //===================================================================================================================================
        // Dynamic element
        //===================================================================================================================================


        [Given(@"I click on element with attribute ""([^""]*)"" and value ""([^""]*)"" on the adjacent table has text ""([^""]*)""")]
        public async Task GivenIClickOnElementWithAttributeAndValueOnTheAdjacentTableHasText(string attributeName, string attributeValue, string tableCellText)
        {
            await _commonControls.ClickOnElementAdjacentToTableCell(tableCellText, attributeName, attributeValue);
        }

        [Given(@"I click the element ""([^""]*)"" of having attribute ""([^""]*)"" having the value ""([^""]*)""")]
        public async Task GivenIClickTheElementOfHavingAttributeHavingTheValue(string element, string attribute, string attributeValue)
        {
            await _commonControls.ClickOnElementBasedOnAttribute(element, attribute, attributeValue);
        }

        [Given(@"I click the element contains the text ""([^""]*)""")]
        public async Task GivenIClickTheElementContainsTheText(string elementText)
        {
            await _commonControls.ClickOnElementByTextOnIt(elementText);
        }

        [Given(@"I click on Three Dots on the table has index ""([^""]*)"" and on row index ""([^""]*)"" and cell index ""([^""]*)""")]
        public async Task GivenIClickOnThreeDotsOnTheTableHasIndexAndOnRowIndexAndCellIndex(string tableIndex, string rowIndex, string cellIndex)
        {
            await _commonControls.ClickOnElementFromTableUsingRowAndCellIndex(tableIndex, rowIndex, cellIndex);
        }



    }
}
