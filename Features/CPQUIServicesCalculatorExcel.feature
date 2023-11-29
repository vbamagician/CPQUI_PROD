Feature: CPQUIServicesCalculatorExcel

This feature is dedicated to testing the UI Health of the Excel Based Services Calculator Configurator within the CPQ UI. 
The primary objective is to ensure a consistent and seamless user experience while configuring a new 
contract for the Services Calculator Based Excel Configurator.

  @smoke
  Scenario: Verify UI Health while Configuring Excel Based Services Calculator Configurator in CPQ UI
	Given I Navigate to CPQ UI Page
		And I Enter following Login Details and Click Login Button
			| Username                            | Password                 |
			| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
		And I click on New Contract Button
		And I configure client details for new Contract
		And I click on Service "Unified Support for Azure"
		And I click on Configure Now Button
		And I click on Download Button to download configurator for EBC
		And I see the popup window and close it
		And I upload the Excel based configurator
	When When I click Finish from Scope Page for EBC
	Then I should see the value of contract