using CPQUI.Controls;
using CPQUI.Drivers;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CommonStepDefinitions
    {
        private readonly Driver _driver;
        private readonly CommonControls _commonControls;

        CommonStepDefinitions(Driver driver)
        {
            _driver = driver;
            _commonControls = new CommonControls(_driver.Page);
        }

        //===================================================================================================================================
        // Buttons:
        //      1. I click the button containing the text
        //      2. Solution Card
        //      3. Wait for button upto defined seconds and if button does not found then skip clicking on it. 
        //      4. Click on the button based on it's parent class test. Simply NEXT and FINISH button 
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


        //===================================================================================================================================
        // TextBox
        //===================================================================================================================================

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
    }
}
