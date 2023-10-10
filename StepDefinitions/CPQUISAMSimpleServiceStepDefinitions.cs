using CPQUI.Drivers;
using CPQUI.Solutions;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class CPQUISAMSimpleServiceStepDefinitions
    {

        private readonly Driver _driver;
        private readonly SAMSimpleSolution _samsimpleSolution;


        CPQUISAMSimpleServiceStepDefinitions(Driver driver)
        {
            _driver = driver;
            _samsimpleSolution = new SAMSimpleSolution(_driver.Page);
        }

        [Given(@"I choose ""([^""]*)"" to deploy the SAMSimple inventory agent on client Devices")]
        public async Task GivenIChooseToDeployTheSAMSimpleInventoryAgentOnClientDevices(string yES)
        {
            await _samsimpleSolution.ChooseYESToDeploySAMSimpleInventoryAgentOnClientDevices(yES);
        }

        [Given(@"I choose option of ""([^""]*)""")]
        public async Task GivenIChooseOptionOf(string p0)
        {
            await _samsimpleSolution.ChooseOptionToDeployeSAMSimpleAgentsToSpecificDevicesInScope(p0);
        }

        [Given(@"I click on Next Button From Definition Page for SAMSimple")]
        public async Task GivenIClickOnNextButtonFromDefinitionPageForSAMSimple()
        {
            const string definitionPagePlacement = "next-1";
            await _samsimpleSolution.ClickOnNextButtonFromDefinitionPageForSAMSimple(definitionPagePlacement);
        }

        [Given(@"I select publisher as ""([^""]*)""")]
        public async Task GivenISelectPublisherAs(string activePDF)
        {
            await _samsimpleSolution.SelectPublisher(activePDF);
        }

        [Given(@"I entered number of estimated end-user devices as ""([^""]*)""")]
        public async Task GivenIEnteredNumberOfEstimatedEndUserDevicesAs(string p0)
        {
            await _samsimpleSolution.EnterNumberOfEstimatedEndUserDevice(p0);
        }

        [Given(@"I entered number of estimated physical and virtual servers as ""([^""]*)""")]
        public async Task GivenIEnteredNumberOfEstimatedPhysicalAndVirtualServersAs(string p0)
        {
            await _samsimpleSolution.EnterNumberOfEstimatedPhysicalAndVirtualServers(p0);
        }

        [Given(@"I entered number of estimated users as ""([^""]*)""")]
        public async Task GivenIEnteredNumberOfEstimatedUsersAs(string p0)
        {
            await _samsimpleSolution.EnterNumberOfEstimatedUsers(p0);
        }

        [Given(@"I select Operating System in use as ""([^""]*)""")]
        public async Task GivenISelectOperatingSystemInUseAs(string linux)
        {
            await _samsimpleSolution.SelectOperatingSystemInUse(linux);
        }

        [Given(@"I entered number of trusted domain as ""([^""]*)"" for trusted domain")]
        public async Task GivenIEnteredNumberOfTrustedDomainAsForTrustedDomain(string p0)
        {
            await _samsimpleSolution.EnterNumberOfTrustedDomains(p0);
        }

        [Given(@"I entered number of untrusted domain as ""([^""]*)"" for untrusted domain")]
        public async Task GivenIEnteredNumberOfUntrustedDomainAsForUntrustedDomain(string p0)
        {
            await _samsimpleSolution.EnterNumberOfUntrustedDomains(p0);
        }

        [Given(@"I entered number of geographic location as ""([^""]*)""")]
        public async Task GivenIEnteredNumberOfGeographicLocationAs(string p0)
        {
            await _samsimpleSolution.EnterNumberOfGeogrphicLocation(p0);
        }

        [Given(@"I entered number of segregated networks as ""([^""]*)""")]
        public async Task GivenIEnteredNumberOfSegregatedNetworksAs(string p0)
        {
            await _samsimpleSolution.EnterNumberOfSegregatedNetworks(p0);
        }

        [Given(@"I select Inventory Inventory Data Source is deployed into the clients environment as ""([^""]*)""")]
        public async Task GivenISelectInventoryInventoryDataSourceIsDeployedIntoTheClientsEnvironmentAs(string p0)
        {
            await _samsimpleSolution.SelectInventoryDataSourceWhichIsDeployedIntoClientEnvironment(p0);
        }

        [Given(@"I select an option as ""([^""]*)"" method of software distrubution")]
        public async Task GivenISelectAnOptionAsMethodOfSoftwareDistrubution(string p0)
        {
            await _samsimpleSolution.SelectAnOptionForMethodOfSoftwareDistribution(p0);
        }

        [Given(@"I select virtualization platform as ""([^""]*)""")]
        public async Task GivenISelectVirtualizationPlatformAs(string p0)
        {
            await _samsimpleSolution.SelectAnOptionForVirtualizationPlatform(p0);
        }

        [Given(@"I select application virtualization platform as ""([^""]*)""")]
        public async Task GivenISelectApplicationVirtualizationPlatformAs(string p0)
        {
            await _samsimpleSolution.SelectAnOptionForApplicationVirtualizationPlatform(p0);
        }

        [Given(@"I select SaaS Platform as ""([^""]*)""")]
        public async Task GivenISelectSaaSPlatformAs(string p0)
        {
            await _samsimpleSolution.SelectAnOptionForSAASPlatform(p0);
        }

        [Given(@"I click Next on Scope Page for SAMSimple")]
        public async Task GivenIClickNextOnScopePageForSAMSimple()
        {
            const string scopePagePlacementText = "next-2";
            await _samsimpleSolution.ClickOnNextButtonFromScopePage(scopePagePlacementText);
        }

        [Given(@"I select an option for implementation level as ""([^""]*)""")]
        public async Task GivenISelectAnOptionForImplementationLevelAs(string easy)
        {
            await _samsimpleSolution.SelectAnOptionForImplementationLevel(easy);
        }

        [Given(@"I click Next Customer Pricing Page for SAMSimple")]
        public async Task GivenIClickNextCustomerPricingPageForSAMSimple()
        {
            const string customerPricingPagePlacementText = "next-3";
            await _samsimpleSolution.ClickOnNextButtonFromCustomerPricingPage(customerPricingPagePlacementText);
        }

        [Given(@"I click Next Margin As Sold Page for SAMSimple")]
        public async Task GivenIClickNextMarginAsSoldPageForSAMSimple()
        {
            const string marginPagePlacementText = "next-4";
            await _samsimpleSolution.ClickOnNextButtonFromMarginAsSoldPage(marginPagePlacementText);
        }
    // Trusted Domains

        [Given(@"I click on Add Domain Button to Add Trusted Domain")]
        public async Task GivenIClickOnAddDomainButtonToAddTrustedDomain()
        {
            await _samsimpleSolution.ClickOnAddDomainButtonForTrustedDomain();
        }

        [Given(@"I select ""([^""]*)"" as option from Domain Form for Trusted Domain")]
        public async Task GivenISelectAsOptionFromDomainFormForTrustedDomain(string trusted)
        {
            
            await _samsimpleSolution.SelectOptionFromDomainForm(trusted);
        }

        [Given(@"I entered domain name as ""([^""]*)"" for Trusted Domain")]
        public async Task GivenIEnteredDomainNameAsForTrustedDomain(string aBCD)
        {
            await _samsimpleSolution.EnterDomainNameForTrustedDomain(aBCD);
        }

        [Given(@"I click on Save and Add Another button to add one more domain")]
        public async Task GivenIClickOnSaveAndAddAnotherButtonToAddOneMoreDomain()
        {
        await _samsimpleSolution.ClickOnSaveAndAddAnotherButtonForTrustedDomain();
        }

    // Untrusted Domains

        [Given(@"I select ""([^""]*)"" as option from Domain Form for Untrusted Domain")]
        public async Task GivenISelectAsOptionFromDomainFormForUntrustedDomain(string untrusted)
        {
        await _samsimpleSolution.SelectOptionFromDomainForm(untrusted);
        }

        [Given(@"I entered domain name as ""([^""]*)"" for Untrusted Domain")]
        public async Task GivenIEnteredDomainNameAsForUntrustedDomain(string aBCD)
        {
        await _samsimpleSolution.EnterDomainNameForUntrustedDomain(aBCD);
        }

        [Given(@"I click on Save button to close domain form")]
        public async Task GivenIClickOnSaveButtonToCloseDomainForm()
        {
        await _samsimpleSolution.ClickOnSaveButtonToCloseLocationForm();
        }
    
    // Geographic Locations
        
        [Given(@"I click on Add Location Button To Add Gegraphic Location")]
        public async Task GivenIClickOnAddLocationButtonToAddGegraphicLocation()
        {
        await _samsimpleSolution.ClickOnAddLocationButton();
        }

        [Given(@"I entered geographic location as ""([^""]*)""")]
        public async Task GivenIEnteredGeographicLocationAs(string india)
        {
        await _samsimpleSolution.EnterGeographicLocation(india);
        }

        [Given(@"I click on Save button to close Location form")]
        public async Task GivenIClickOnSaveButtonToCloseLocationForm()
        {
        await _samsimpleSolution.ClickOnSaveButtonToCloseLocationForm();
        }

    // Segregated Network

        [Given(@"I click on Add Network button To Add Segregated Networks")]
        public async Task GivenIClickOnAddNetworkButtonToAddSegregatedNetworks()
        {
        await _samsimpleSolution.ClickOnAddSegregatedNetworksButton();
        }

        [Given(@"I entered Segregated Network as ""([^""]*)""")]
        public async Task GivenIEnteredSegregatedNetworkAs(string aBCD)
        {
            await _samsimpleSolution.EnterSegregtedNetwork(aBCD);
        }

        [Given(@"I click on Save button to close Segregated Networks Form")]
        public async Task GivenIClickOnSaveButtonToCloseSegregatedNetworksForm()
        {
        await _samsimpleSolution.ClickOnSaveButtonToCloseSegregatedNetworksForm();
        }

    // Application Virtualization

        [Given(@"I click on Add Application virtualization Details button To Add Virtual Application Details")]
        public async Task GivenIClickOnAddApplicationVirtualizationDetailsButtonToAddVirtualApplicationDetails()
        {
        await _samsimpleSolution.ClickOnAddApplicationVirtualizationDetailsButton();
        }

        [Given(@"I entered product as ""([^""]*)"" for Application virtualization")]
        public async Task GivenIEnteredProductAsForApplicationVirtualization(string aBCD)
        {
        await _samsimpleSolution.EnterProductNameForApplicationVirtualizationDetails(aBCD);
        }

        [Given(@"I entered Version as ""([^""]*)"" for Application virtualization")]
        public async Task GivenIEnteredVersionAsForApplicationVirtualization(string p0)
        {
        await _samsimpleSolution.EnterVersionForApplicationVirtualizationDetails(p0);
        }

        [Given(@"I entered Edition as ""([^""]*)"" for Application virtualization")]
        public async Task GivenIEnteredEditionAsForApplicationVirtualization(string aBCD)
        {
        await _samsimpleSolution.EnterEditionForApplicationVirtualizationDetails(aBCD);
        }

        [Given(@"I click on Save button to close Application Virtualization form")]
        public async Task GivenIClickOnSaveButtonToCloseApplicationVirtualizationForm()
        {
        await _samsimpleSolution.ClickOnSaveButtonToCloseApplicationVirtualizationForm();
        }

    // Virtualization Platform

        [Given(@"I click on Add Virtualization Platform Details button To Add Virtualization Platform Details")]
        public async Task GivenIClickOnAddVirtualizationPlatformDetailsButtonToAddVirtualizationPlatformDetails()
        {
        await _samsimpleSolution.ClickOnAddAddVirtualizationPlatformDetailsButton();
        }

        [Given(@"I entered product as ""([^""]*)"" for Virtualization Platform")]
        public async Task GivenIEnteredProductAsForVirtualizationPlatform(string aBCD)
        {
        await _samsimpleSolution.EnterProductNameForVirtualizationPlatformDetails(aBCD);
        }

        [Given(@"I entered Version as ""([^""]*)"" for Virtualization Platform")]
        public async Task GivenIEnteredVersionAsForVirtualizationPlatform(string p0)
        {
        await _samsimpleSolution.EnterVersionForVirtualizationPlatformDetails(p0);
        }

        [Given(@"I entered Edition as ""([^""]*)"" for Virtualization Platform")]
        public async Task GivenIEnteredEditionAsForVirtualizationPlatform(string aBCD)
        {
        await _samsimpleSolution.EnterEditionForVirtualizationPlatformDetails(aBCD);
        }

        [Given(@"I click on Save button to close Virtualization Platform form")]
        public async Task GivenIClickOnSaveButtonToCloseVirtualizationPlatformForm()
        {
        await _samsimpleSolution.ClickOnSaveButtonToCloseVirtualizationPlatformForm();
        }


    // Contractual Definitions


        [Given(@"I select Invoice Frequency option as ""([^""]*)""")]
        public async Task GivenISelectInvoiceFrequencyOptionAs(string p0)
        {
        await _samsimpleSolution.SelectInvoiceFrequencyOptionQuarterlyConsumptionSubscriptionInvoice(p0);
        }

        [Given(@"I click Next on Questionaire Page for SAMSimple")]
        public async Task GivenIClickNextOnQuestionairePageForSAMSimple()
        {
        const string questionnairePlacementText = "next-5";
        await _samsimpleSolution.ClickOnNextButtonFromQuestionnairePage(questionnairePlacementText);
        }
    }
}