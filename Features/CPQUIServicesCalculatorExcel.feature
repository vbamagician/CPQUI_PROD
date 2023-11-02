Feature: CPQUIServicesCalculatorExcel

THis feature will test the solution which has Excel Based Configurator. We shall test the UI Stability and Match the numbers

@smoke
Scenario: Test Excel Based Coonfigurator Solution
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
	And I click next from ScopePage for EBC
	#When When I click Finish from Margin As Sold Page for EBC
	Then I should see the value of contract