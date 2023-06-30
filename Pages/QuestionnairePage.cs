using CPQUI.Controls;
using Microsoft.Playwright;

namespace CPQUI.Pages
{
    internal class QuestionnairePage
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        // Constructor
        public QuestionnairePage(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        //Common Properties 

        //*****************************************************************************************************************
        //Properties of Azure Simple 
        //*****************************************************************************************************************
        private ILocator AddMicrosoftTenantButton => _page.Locator("//div[contains(@class,'column1-60')]/div/div[2]/div/div[2]//button");
        private ILocator TenantNameTextBox => _page.Locator("//div[contains(@class,'kk-flyout')]/div/div[2]/div[1]/div[5]//input");
        private ILocator ProdORNoProdRadioButtons => _page.GetByText("Production", new() { Exact = true });
        private ILocator SubscriptionIDTextBox => _page.Locator("//div[contains(@class,'kk-flyout')]/div/div[2]/div[1]/div[7]//input");
        private ILocator SaveTenantButton => _page.Locator("//div[contains(@class,'kk-flyout')]/div/div[2]/div[1]/div[9]//button");
        private ILocator PrePaymentTextBox => _page.Locator("//label[contains(text(),'Amount')]/../..//input");

        //*****************************************************************************************************************
        //Properties of Security Posture Assess. Example 
        //*****************************************************************************************************************
        private ILocator StakeholdersToBeInterviewedTextBox => _page.Locator("//label[contains(text(),'Stakeholders to be interviewed')]//../..//textarea");
        private ILocator AWSAccountsToBeReviewedTextBox => _page.Locator("//label[contains(text(),'AWS Accounts to be reviewed')]//../..//textarea");
        private ILocator WorkloadsToBeReviewedTextBox => _page.Locator("//label[contains(text(),'Workloads to be reviewed')]//../..//textarea");
        private ILocator EnvironmenToBeReviewedTextBox => _page.Locator("//label[contains(text(),'Environment to be reviewed')]//../..//textarea");
        private ILocator ComplianceAndRegulatoryStandardsTextbox => _page.Locator("//label[contains(text(),'Compliance and regulatory standards')]//../..//textarea");
        private ILocator PlaceOfPerformanceTextBox => _page.Locator("//label[contains(text(),'Place of Performance')]//../..//textarea");
        private ILocator OtherExclusionsTextBox => _page.Locator("//label[contains(text(),'Other Exclusions')]//../..//textarea");

        //*****************************************************************************************************************
        //Properties of Microsoft Agreement Service 
        //*****************************************************************************************************************
        private ILocator FinOpsFundamentalsAndKickOffRemoteRadioButton => _page.Locator("//label[contains(text(),'FinOps Fundamentals and KickOff')]/../..//label[contains(text(),'Remote')]");
        private ILocator SpendManagementImplementationOrOnboardingRemoteRadioButton => _page.Locator("//label[contains(text(),'Spend Management Implementation/Onboarding')]/../..//label[contains(text(),'Remote')]\r\n");
        private ILocator PyraCloudSpendManagementTrainingRemoteRadioButton => _page.Locator("//label[contains(text(),'PyraCloud Spend Management Training')]/../..//label[contains(text(),'Remote')]");
        private ILocator CloudCostOptimizationImplementationRemoteRadioButton => _page.Locator("//label[contains(text(),'Cloud Cost Optimization Implementation')]/../..//label[contains(text(),'Remote')]");



        //  MM    MM  EEEEEE  TTTTTT  HH    HH  OOOOO  DDDDD    SSSSSS
        //  MMM  MMM  EE        TT    HH    HH OO   OO DD   DD  SS
        //  MM MM MM  EEEE      TT    HHHHHHHH OO   OO DD   DD  SSSSSS
        //  MM    MM  EE        TT    HH    HH OO   OO DD   DD      SS
        //  MM    MM  EEEEEE    TT    HH    HH  OOOOO  DDDDDD   SSSSSS



        //*****************************************************************************************************************
        //Methods of Microsoft Agreement Service 
        //*****************************************************************************************************************
        public async Task ChooseRemoteOptionForFinOpsFundamentalsAndKickOff()
        {
            await FinOpsFundamentalsAndKickOffRemoteRadioButton.ClickAsync();
        }

        public async Task ChooseRemoteOptionForSpendManagementImplementationOrOnboarding()
        {
            await SpendManagementImplementationOrOnboardingRemoteRadioButton.ClickAsync();
        }

        public async Task ChooseRemoteOptionForPyraCloudSpendManagementTraining()
        {
            await PyraCloudSpendManagementTrainingRemoteRadioButton.ClickAsync();
        }

        public async Task ChooseRemoteOptionForCloudCostOptimizationImplementation()
        {
            await CloudCostOptimizationImplementationRemoteRadioButton.ClickAsync();
        }


        //*****************************************************************************************************************
        //Methods of Security Posture Assess. Example
        //*****************************************************************************************************************
        public async Task FillQuestionnairePageQuestionsForSPA()
        {
            await StakeholdersToBeInterviewedTextBox.FillAsync("ABCD");
            await AWSAccountsToBeReviewedTextBox.FillAsync("ABCD");
            await WorkloadsToBeReviewedTextBox.FillAsync("ABCD");
            await EnvironmenToBeReviewedTextBox.FillAsync("ABCD");
            await ComplianceAndRegulatoryStandardsTextbox.FillAsync("ABCD");
            await PlaceOfPerformanceTextBox.FillAsync("ABCD");
            await OtherExclusionsTextBox.FillAsync("ABCD");
        }

        //*****************************************************************************************************************
        //Methods of Azure Simple 
        //*****************************************************************************************************************
        public async Task AddMicrosoftTenant()
        {
            await AddMicrosoftTenantButton.ClickAsync();
            await TenantNameTextBox.FillAsync("ABCD");
            await ProdORNoProdRadioButtons.ClickAsync();
            await SubscriptionIDTextBox.FillAsync("ABCD");
            await SaveTenantButton.ClickAsync();
        }

        public async Task AddPrepaymentAmount(string p0)
        {
            await PrePaymentTextBox.FillAsync(p0);
        }

        //*****************************************************************************************************************
        // Common Methods 
        //*****************************************************************************************************************
        public async Task ClickOnNextButtonFromQuestionnairePage(string pagePlacementText)
        {
            await _controls.WaitForPageAppears(pagePlacementText);
            await _controls.NextButton.ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}
