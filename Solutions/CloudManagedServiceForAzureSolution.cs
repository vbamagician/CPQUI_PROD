using CPQUI.Controls;
using Microsoft.Playwright;

namespace CPQUI.Solutions
{
    internal class CloudManagedServiceForAzureSolution
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        //===============================================================================================================================
        // Contructor
        //===============================================================================================================================

        public CloudManagedServiceForAzureSolution(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }


        //===============================================================================================================================
        // Dynamic Properties of Page Elements for reusability
        //===============================================================================================================================

        // Radio Button Group Option locating based on the label text 
        private ILocator DynamicRadioButtonsGroupOptionByLabel(string label, string optionCaption) => _page.Locator($"//label[contains(text()[normalize-space()],'{label}')]/../..//label[contains(text()[normalize-space()],'{optionCaption}')]");

        // Identical Radio Button Group Option when label is same. 
        private ILocator DynamicIdenticalRadioButtongroupOption(string optionCaption, string itemIndex) => _page.Locator($"(//label[contains(text()[normalize-space()],'{optionCaption}')])[{itemIndex}]");

        // Identical Textboxes on a single page having similar labels 
        private ILocator DynamicIdenticalFieldsOfTextBox(string label, string itemIndex) => _page.Locator($"(//label[contains(text()[normalize-space()],'{label}')]/../..//input)[{itemIndex}]");

        // Dynamic DropDown control locating based on the label text 
        private ILocator DynamicDropDownOptionByLabel(string label) => _page.Locator($"//label[contains(text()[normalize-space()],'{label}')]/../..//select");



        //===============================================================================================================================
        // Common Methods
        //===============================================================================================================================


        public async Task ClickOnNextButtonPage(string pagePlacementText)
        {
            // Take Screenshot 
            await _controls.TakeScreenShot();

            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }


        //===============================================================================================================================
        // Methods
        //===============================================================================================================================


        //=======================
        // Definition Page 
        //=======================

        public async Task SelectOptionForServiceSelectionOfAzureEssentialForCSP(string optionCaption)
        {
            await DynamicRadioButtonsGroupOptionByLabel("Azure Essentials for CSP?", optionCaption).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task SelectOptionForServiceSelectionOfAzureEssentialsForEA(string optionCaption)
        {
            await DynamicRadioButtonsGroupOptionByLabel("Azure Essentials for EA?", optionCaption).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task SelectOptionForServiceSelectionOfAzureAdvanced(string optionCaption)
        {
            await DynamicRadioButtonsGroupOptionByLabel("Azure Advanced?", optionCaption).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
        

        //=======================
        // Scope Page 
        //=======================



        //Azure Essentials for CSP

        public async Task EnterEstimatedConsumptionPerMonthForAzureEssentialForCSP(string amount)
        {
            await DynamicIdenticalFieldsOfTextBox("Estimated Consumption per month", "1").FillAsync(amount);
        }

        public async Task ChooseOptionAboutOfferingDiscountForAzureEssentialForCSP(string decision)
        {
            await DynamicIdenticalRadioButtongroupOption(decision, "1").ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task EnterDiscountPercentageForAzureEssentialForCSP(string discount)
        {
            await DynamicIdenticalFieldsOfTextBox("Discount %:", "1").FillAsync(discount);
        }



        //Azure Essentials for EA

        public async Task EnterEstimatedConsumptionPerMonthForAzureEssentialsForEA(string amount)
        {
            await DynamicIdenticalFieldsOfTextBox("Estimated Consumption per month", "2").FillAsync(amount);
        }

        public async Task ChooseOptionAboutOfferingDiscountForAzureEssentialsForEA(string decision)
        {
            await DynamicIdenticalRadioButtongroupOption(decision, "2").ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task EnterDiscountPercentageForAzureEssentialsForEA(string discount)
        {
            await DynamicIdenticalFieldsOfTextBox("Discount %:", "2").FillAsync(discount);
        }


        //Azure Advanced

        public async Task EnterEstimatedConsumptionPerMonthForAzureAdvanced(string amount)
        {
            await DynamicIdenticalFieldsOfTextBox("Estimated Consumption per month", "3").FillAsync(amount);
        }

        public async Task ChooseOptionAboutOfferingDiscountForAzureAdvanced(string decision)
        {
            await DynamicIdenticalRadioButtongroupOption(decision, "3").ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task EnterDiscountPercentageForAzureAdvanced(string discount)
        {
            await DynamicIdenticalFieldsOfTextBox("Discount %:", "3").FillAsync(discount);
        }


        //Azure Account Transfer


        public async Task SelectOptionForAzureAccountTransfer(string optionValue)
        {
            await DynamicDropDownOptionByLabel("Please select from one of the following transfer options:").SelectOptionAsync(new[] { optionValue });
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}
