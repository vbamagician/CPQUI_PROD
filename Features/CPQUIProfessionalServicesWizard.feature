Feature: CPQUIProfessionalServicesWizard

This feature will test General Services of Azure as a part of Professional Services and will check the for the 
UI stability and validate the values came by choosing attributes for the task

@smoke
Scenario: Test UI stability of General Services for Azure by Importing WBS
	Given I Navigate to CPQ UI Page "https://contracts.softwareone.com/login/secondary-login"
	And I Enter following Login Details and Click Login Button
		| Username                            | Password                 |
		| helpdesk-scg.global@softwareone.com | lT60VQvBz3RcY3LSPPikPg== |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "General Services for Azure"
	And I click on Configure Now Button
	And I close Contract Unavailable Popup Window
	And I choose Time & Material from Type of Contract Question
	And I entered Contract Duration in Month as "36"
	And I click on Next Button From Definition Page
	And I choose "Days" Option from build your plan Question
	And I downloaded the WBS template and saved as "WBSExport.xls"
	And I click on Import Button
	And I click on Choose Files Button and Choose "WBSExport.xls" File
	When I click on Upload Button
	Then I should see the sell prices of import task as "7,328.22"
	And I click on Next Button from Scoping Page 
	And I click on Next Button from OtherCosts Page
	And I click on Next Button from CustomerPricing Page
	When I click on Finish Button from CustomerVariables Page
	Then I should see the Opprtunity Value as "EUR 7,328.22"

@smoke
Scenario: Test UI stability of General Services For Azure by Manually Inserting WBS
	Given I Navigate to CPQ UI Page "https://contracts.softwareone.com/login/secondary-login"
	And I Enter following Login Details and Click Login Button
		| Username                            | Password       |
		| helpdesk-scg.global@softwareone.com | lT60VQvBz3RcY3LSPPikPg== |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "General Services for Azure"
	And I click on Configure Now Button
	And I close Contract Unavailable Popup Window
	And I choose Time & Material from Type of Contract Question
	And I entered Contract Duration in Month as "36"
	And I click on Next Button From Definition Page
	And I choose "Days" Option from build your plan Question
	And I click on Add Button to add new Task
	And I Entered Title of the Task as "Task 1"
	And I Entered Efforts of the Task as "100"
	And I selected resource as Consultant as option number "33"
	And I selected country as "Australia (SWO_AU)" 
	When I click on Confirm Button
	Then I should see the sell price of the manual Task as "107,243.56"
	And I click on Next Button from Scoping Page 
	And I click on Next Button from OtherCosts Page
	And I click on Next Button from CustomerPricing Page
	When I click on Finish Button from CustomerVariables Page
	Then I should see the Opprtunity Value as "EUR 107,243.56"