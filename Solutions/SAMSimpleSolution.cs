using CPQUI.Controls;
using Microsoft.Playwright;

namespace CPQUI.Solutions
{
    internal class SAMSimpleSolution
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        //===============================================================================================================================
        // Contructor
        //===============================================================================================================================

        public SAMSimpleSolution(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        //===============================================================================================================================
        // Dynamic Properties of Page Elements for reusability
        //===============================================================================================================================

        //Radio Button Group
        private ILocator DynamicOptionOfRadioButtonGroup(string value) => _page.Locator($"//label[contains(text()[normalize-space()],'{value}')]");

        //Table Elements
        private ILocator DynamicTilesOfTableElement(string value) => _page.Locator($"//span[contains(text()[normalize-space()],'{value}')]/../..");

        //Textbox
        private ILocator DynamicFieldOfTextBox(string value) => _page.Locator($"//label[contains(text()[normalize-space()],'{value}')]/../..//input");
        private ILocator StrictFieldOfTextBox(string value) => _page.Locator($"//label[text()[normalize-space()]='{value}']/../..//input");

        //Buttons
        private ILocator DynamicPopupFormOpenerButton(string value) => _page.Locator($"//button[contains(text()[normalize-space()],'{value}')]");
        private ILocator StaticSaveAndAddAnotherPopupFormButton() => _page.Locator("//button[contains(text()[normalize-space()],'Save & Add another')]");
        private ILocator DynamicPopupFormSaveButton() => _page.Locator("(//button[contains(text()[normalize-space()],'Save')])[1]");

        //Dropdown or ComboBox or List
        private ILocator DynamicOptionOfDropDown(string searchText) => _page.Locator($"//label[text()[normalize-space()]='{searchText}']/../..//select");



        //===============================================================================================================================
        // Methods of SAM Simple Solution
        //===============================================================================================================================



        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        // Definition Page Methods
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        public async Task ChooseYESToDeploySAMSimpleInventoryAgentOnClientDevices(string option)
        {
            await DynamicOptionOfRadioButtonGroup(option).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task ChooseOptionToDeployeSAMSimpleAgentsToSpecificDevicesInScope(string option)
        {
            await DynamicOptionOfRadioButtonGroup(option).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task ClickOnNextButtonFromDefinitionPageForSAMSimple(string pagePlacementText)
        {
            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        // Scope Page Methods
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        public async Task SelectPublisher(string publisher)
        {
            await DynamicTilesOfTableElement(publisher).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task EnterNumberOfEstimatedEndUserDevice(string p0)
        {
            await DynamicFieldOfTextBox("# End-user Device:").FillAsync(p0);
        }

        public async Task EnterNumberOfEstimatedPhysicalAndVirtualServers(string p0)
        {
            await DynamicFieldOfTextBox("# Servers (Physical & Virtual):").FillAsync(p0);
        }

        public async Task EnterNumberOfEstimatedUsers(string p0)
        {
            await DynamicFieldOfTextBox("# Users:").FillAsync(p0);
        }

        public async Task SelectOperatingSystemInUse(string linux)
        {
            await DynamicTilesOfTableElement(linux).ClickAsync();
        }

        public async Task EnterNumberOfTrustedDomains(string p0)
        {
            await DynamicFieldOfTextBox("# Trusted Domains:").FillAsync(p0);
        }

        public async Task EnterNumberOfUntrustedDomains(string p0)
        {
            await DynamicFieldOfTextBox("# Untrusted Domains:").FillAsync(p0);
        }

        public async Task EnterNumberOfGeogrphicLocation(string p0)
        {
            await DynamicFieldOfTextBox("# Locations:").FillAsync(p0);
        }

        public async Task EnterNumberOfSegregatedNetworks(string p0)
        {
            await DynamicFieldOfTextBox("# Segregated Networks:").FillAsync(p0);
        }

        public async Task SelectInventoryDataSourceWhichIsDeployedIntoClientEnvironment(string p0)
        {
            await DynamicTilesOfTableElement(p0).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task SelectAnOptionForMethodOfSoftwareDistribution(string p0)
        {
            await DynamicTilesOfTableElement(p0).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task SelectAnOptionForVirtualizationPlatform(string p0)
        {
            await DynamicTilesOfTableElement(p0).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task SelectAnOptionForApplicationVirtualizationPlatform(string p0)
        {
            await DynamicTilesOfTableElement(p0).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task SelectAnOptionForSAASPlatform(string p0)
        {
            await DynamicTilesOfTableElement(p0).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task ClickOnNextButtonFromScopePage(string pagePlacementText)
        {
            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }


        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        // Customer Pricing Page Methods
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        public async Task SelectAnOptionForImplementationLevel(string p0)
        {
            await DynamicOptionOfRadioButtonGroup(p0).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task ClickOnNextButtonFromCustomerPricingPage(string pagePlacementText)
        {
            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }


        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        // Margin As Sold Page Methods
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        public async Task ClickOnNextButtonFromMarginAsSoldPage(string pagePlacementText)
        {
            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }


        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        // Questionnaire Page Methods
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    // Trusted Domains 

        public async Task ClickOnAddDomainButtonForTrustedDomain()
        {
            await DynamicPopupFormOpenerButton("Add Domain").ClickAsync();
        }

        public async Task SelectOptionFromDomainForm(string option)
        {
            await DynamicOptionOfDropDown("Is this a trusted or untrusted domain?").SelectOptionAsync(new[] { option });
        }

        public async Task EnterDomainNameForTrustedDomain(string domain)
        {
            await StrictFieldOfTextBox("Domain name:").FillAsync(domain);
        }

        public async Task ClickOnSaveAndAddAnotherButtonForTrustedDomain()
        {
            await StaticSaveAndAddAnotherPopupFormButton().ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

    // Untrusted Domains

        public async Task EnterDomainNameForUntrustedDomain(string domain)
        {
            await StrictFieldOfTextBox("Domain name:").FillAsync(domain);
        }

        public async Task ClickOnSaveButtonToCloseDomainForm()
        {
            await DynamicPopupFormSaveButton().ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }


        // Geographic Locations

        public async Task ClickOnAddLocationButton()
        {
            await DynamicPopupFormOpenerButton("Add Location").ClickAsync();
        }

        public async Task EnterGeographicLocation(string geographicLocation)
        {
            await StrictFieldOfTextBox("Geographic location:").FillAsync(geographicLocation);   
        }

        public async Task ClickOnSaveButtonToCloseLocationForm()
        {
            await DynamicPopupFormSaveButton().ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }


    // Segregated Network

        public async Task ClickOnAddSegregatedNetworksButton()
        {
            await DynamicPopupFormOpenerButton("Add Network").ClickAsync();
        }

        public async Task EnterSegregtedNetwork(string segregatedNetwork)
        {
            await StrictFieldOfTextBox("Details:").FillAsync((string)segregatedNetwork);
        }

        public async Task ClickOnSaveButtonToCloseSegregatedNetworksForm()
        {
            await DynamicPopupFormSaveButton().ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }


    // Application Virtualization

        public async Task ClickOnAddApplicationVirtualizationDetailsButton()
        {
            await DynamicPopupFormOpenerButton("Add Application Virtualization Details").ClickAsync();
        }

        public async Task EnterProductNameForApplicationVirtualizationDetails(string productName)
        {
            await StrictFieldOfTextBox("Product:").FillAsync(productName);
        }

        public async Task EnterVersionForApplicationVirtualizationDetails(string versionName)
        {
            await StrictFieldOfTextBox("Version:").FillAsync(versionName);
        }

        public async Task EnterEditionForApplicationVirtualizationDetails(string editionName)
        {
            await StrictFieldOfTextBox("Edition:").FillAsync(editionName);
        }

        public async Task ClickOnSaveButtonToCloseApplicationVirtualizationForm()
        {
            await DynamicPopupFormSaveButton().ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

    // Virtualization Platform

        public async Task ClickOnAddAddVirtualizationPlatformDetailsButton()
        {
            await DynamicPopupFormOpenerButton("Add Virtualization Platform Details").ClickAsync();
        }

        public async Task EnterProductNameForVirtualizationPlatformDetails(string productName)
        {
            await StrictFieldOfTextBox("Product:").FillAsync(productName);
        }

        public async Task EnterVersionForVirtualizationPlatformDetails(string versionName)
        {
            await StrictFieldOfTextBox("Version:").FillAsync(versionName);
        }

        public async Task EnterEditionForVirtualizationPlatformDetails(string editionName)
        {
            await StrictFieldOfTextBox("Edition:").FillAsync(editionName);
        }

        public async Task ClickOnSaveButtonToCloseVirtualizationPlatformForm()
        {
            await DynamicPopupFormSaveButton().ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

    // Contractual Definitions

        public async Task SelectInvoiceFrequencyOptionQuarterlyConsumptionSubscriptionInvoice(string option)
        {
            await DynamicOptionOfDropDown("Invoicing frequency:").SelectOptionAsync(new[] { option });
        }

        public async Task ClickOnNextButtonFromQuestionnairePage(string pagePlacementText)
        {
            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}
