using CPQUI.Controls;
using Microsoft.Playwright;
using NUnit.Framework.Internal;
using System.Formats.Asn1;

namespace CPQUI.Pages
{
    internal class ScopePage
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        // Constructor
        public ScopePage(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        //*****************************************************************************************************************
        //Common Properties
        //*****************************************************************************************************************
        private ILocator DynamicRadioButtonOption(string questionLabel, string optionLabel) => _page.Locator($"//label[text()='{questionLabel}']/../..//label[text()='{optionLabel}']");


        //*****************************************************************************************************************
        //Properties for Azure Simple 
        //*****************************************************************************************************************
        private ILocator ECVTextBox => _page.Locator("//label[contains(text(),'Estimated Consumption per month')]/../..//input");
        private ILocator AccountOptions => _page.Locator("//select");

        //*****************************************************************************************************************
        //Properties for Security Posture Assess. Example page 
        //*****************************************************************************************************************
        private ILocator AWSCloudAccountTextBox => _page.Locator("//label[contains(text(),'How many AWS Cloud Accounts would the customer like to do a technical assessment?')]/../..//input");
        private ILocator ServerlessBasedWorkloadsOptions => _page.GetByText("Yes");

        //*****************************************************************************************************************
        //Properties for General Services of Azure / Professional Services Wizard
        //*****************************************************************************************************************
        private ILocator DownloadWBSButton => _page.Locator("//span/a");
        private ILocator ImportWBSButton => _page.GetByRole(AriaRole.Button, new() { Name = " Import" });
        private ILocator ChooseFileButton => _page.GetByText("Choose files");
        //private ILocator UploadDocumentButton => _page.GetByText("Uploadim");
        private ILocator UploadDocumentButton => _page.Locator("//span[text()='Upload']/..");
        private ILocator SellPriceLable => _page.Locator("//tbody/tr[2]/td[11]/span");
        private ILocator AddTaskButton => _page.GetByRole(AriaRole.Button, new() { Name = " Add" });
        private ILocator TaskTitleTextBox => _page.Locator("//label[contains(text(),'Title:')]/../..//input");
        private ILocator TaskEffortInHoursTextBox => _page.Locator("//label[contains(text(),'Effort in Hours:')]/../..//input");
        private ILocator ResourceDropdown => _page.Locator("//label[contains(text(),'Resource:')]/../..//select");
        private ILocator CountryDropdown => _page.Locator("//label[contains(text(),'Country:')]/../..//select");
        private ILocator ConfirmButton => _page.GetByRole(AriaRole.Button, new() { Name = "Confirm" });

        //*****************************************************************************************************************
        //Properties for Microsoft Agreement Service 
        //*****************************************************************************************************************
        private ILocator AddAgreementInformationButton => _page.Locator("//button[contains(text(),'Add')]");
        private ILocator EAEnrollmentTypeRadioButton => _page.Locator("//label[contains(text(),'Enrollment Type')]/../../div[2]/div[1]/ul/li[1]");
        private ILocator PriceLevelARadioButton => _page.Locator("//label[contains(text(),'Enrollment Type')]/../../../div[4]/div[2]/div[1]/ul/li[1]/label");
        private ILocator AnnualAmountTextBox => _page.Locator("//label[contains(text(),'Annual Amount')]/../..//input");
        private ILocator SubmitButton => _page.Locator("//label[contains(text(),'Enrollment Type')]/../../../div[6]//button");

        //*****************************************************************************************************************
        //Properties for Managed UC
        //*****************************************************************************************************************
        private ILocator ThreeYearForAgreementTermRadioButton => _page.Locator("//label[contains(text(), '3 Year')]");
        private ILocator HundredAsNumberOfUsersTextBox => _page.Locator("//label[contains(text(), 'Number of users:')]/../..//input");
        private ILocator HundredAsNumberOfDevicesTextBox => _page.Locator("//label[contains(text(), 'Number of devices:')]/../..//input");


        

        //  MM    MM  EEEEEE  TTTTTT  HH    HH  OOOOO  DDDDD    SSSSSS
        //  MMM  MMM  EE        TT    HH    HH OO   OO DD   DD  SS
        //  MM MM MM  EEEE      TT    HHHHHHHH OO   OO DD   DD  SSSSSS
        //  MM    MM  EE        TT    HH    HH OO   OO DD   DD      SS
        //  MM    MM  EEEEEE    TT    HH    HH  OOOOO  DDDDDD   SSSSSS




        //-----------------------------------------------------------------------------------------------------------------
        //Methods for DevOps Maturity Assessment
        //-----------------------------------------------------------------------------------------------------------------

        public async Task SelectOptionFromRadioButtonGroupForDMA(string questionLabel, string optionLabel)
        { 
            await DynamicRadioButtonOption(questionLabel, optionLabel).ClickAsync();
        }


        //-----------------------------------------------------------------------------------------------------------------
        //Methods for Managed UC
        //-----------------------------------------------------------------------------------------------------------------

        public async Task EnterNumberOfDevices()
        {
            await HundredAsNumberOfDevicesTextBox.FillAsync("100");
        }

        public async Task EnterNumberOfUsers()
        {
            await HundredAsNumberOfUsersTextBox.FillAsync("100");
            await HundredAsNumberOfDevicesTextBox.PressAsync("Enter");
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task ChooseOptionYearForAgreementTerm()
        {
            await ThreeYearForAgreementTermRadioButton.ClickAsync();
        }



        //-----------------------------------------------------------------------------------------------------------------
        //Methods for Microsoft Agreement Service
        //-----------------------------------------------------------------------------------------------------------------
        public async Task ClickOnAddButonToMentionAgreemntThatCustomerGoingToSignWithMicrosoft()
        {
            await AddAgreementInformationButton.ClickAsync();
        }

        public async Task ChooseEnrollmentTypeAsEA()
        {
            await EAEnrollmentTypeRadioButton.ClickAsync();
        }

        public async Task ChoosePriceLevelAsA()
        {
            await PriceLevelARadioButton.ClickAsync();
        }

        public async Task EnterAnnualAmountAs(string p0)
        {
            await AnnualAmountTextBox.FillAsync(p0);
        }

        public async Task ClickOnSubmitButton()
        {
            await SubmitButton.ClickAsync();
        }



        //-----------------------------------------------------------------------------------------------------------------
        //Methods for General Services of Azure / Professional Services Wizard
        //-----------------------------------------------------------------------------------------------------------------

        public async Task ChooseOptionFromBuildYourPlanQuestion(string planType)
        {
            await _page.GetByText(planType).ClickAsync();
        }

        public async Task DownloadWBSFile(string fileName)
        {
            IDownload download = await _page.RunAndWaitForDownloadAsync(async () => await DownloadWBSButton.ClickAsync());
            await download.SaveAsAsync(fileName);
        }

        public async Task ClickOnImportButton()
        {
            await ImportWBSButton.ClickAsync();
        }

        public async Task UploadWBSFile(string fileName)
        {
            IFileChooser fileChooser = await _page.RunAndWaitForFileChooserAsync(async () => await ChooseFileButton.ClickAsync());
            await fileChooser.SetFilesAsync(@"..\..\..\Support\" + fileName);
        }

        public async Task ClickOnUploadButton()
        {
            await UploadDocumentButton.ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task ClickOnAddButtonToAddNewTask()
        {
            await AddTaskButton.ClickAsync();
        }

        public async Task EnterTitleOfTheTask(string taskName)
        {
            await TaskTitleTextBox.FillAsync(taskName);
        }

        public async Task EnterEffortsOfTheTask(string taskEffort)
        {
            await TaskEffortInHoursTextBox.FillAsync(taskEffort);
        }

        public async Task SelectResource(string selectedResource)
        {
            await ResourceDropdown.SelectOptionAsync(new[] { selectedResource });
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task SelectCoutry(string selectedCountry)
        {
            await CountryDropdown.SelectOptionAsync(new[] { selectedCountry });
        }

        public async Task ClickOnConfirmButton()
        {
            await ConfirmButton.ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task<bool> IfSellPriceOccurs()
        {
            string SellValueText = await SellPriceLable.InnerTextAsync();

            if (SellValueText != "")
                return true;
            else
                return false;
        }

        //-----------------------------------------------------------------------------------------------------------------
        //Methods for Security Posture Assess. Example Page
        //-----------------------------------------------------------------------------------------------------------------

        public async Task EnteredValueForTechnicalAssessmentForSPAEA(string AWSAccounts)
        {
            await AWSCloudAccountTextBox.FillAsync(AWSAccounts);
        }

        public async Task ChooseYesForServerlessBasedWorkloadsForSPAE()
        {
            await ServerlessBasedWorkloadsOptions.ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        //-----------------------------------------------------------------------------------------------------------------
        //Methods for Azure Simple 
        //-----------------------------------------------------------------------------------------------------------------

        public async Task EnterEstimatedConsumptionPerMonthValue(string ECV)
        {
            await ECVTextBox.FillAsync(ECV);
        }

        public async Task ChooseNoDiscount()
        {
            await _page.GetByText("No").First.ClickAsync();
        }

        public async Task ChooseCustomerHaveExistingAccountToTransfer()
        {
            await _page.GetByText("Yes").Nth(1).ClickAsync();
            await AccountOptions.SelectOptionAsync(new SelectOptionValue { Index = 1 });
        }

        //-----------------------------------------------------------------------------------------------------------------
        //Common Methods
        //-----------------------------------------------------------------------------------------------------------------

        public async Task ClickOnNextButtonFromScopingPage(string pagePlacementText)
        {
            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}