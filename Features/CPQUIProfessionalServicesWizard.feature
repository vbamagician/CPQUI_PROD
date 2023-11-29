Feature: CPQUIProfessionalServicesWizard

This feature ensures the UI Health of the General Services for Azure section in the CPQ Professional Services Wizard. 
It verifies the smooth and reliable functioning of the user interface when selecting options and entering details, 
both through importing and manually inserting WBS.

@smoke
Scenario: Verify UI Health by Importing WBS for General Services for Azure
    Given I Navigate to CPQ UI Page
	And I Enter following Login Details and Click Login Button
		| Username                            | Password                 |
		| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "General Services for Azure"
	And I click on Configure Now Button
	And I choose Time & Material from Type of Contract Question
	And I entered Contract Duration in Month as "36"
	And I click on Next Button From Definition Page
	#And I choose "Hours" Option from build your plan Question
	And I downloaded the WBS template and saved as "WBSExport.xls"
	And I click on Import Button
	And I click on Choose Files Button and Choose "WBSExport.xls" File
	When I click on Upload Button
	#Then I should see the sell prices of import task as "7,328.22"
	Then I Should see the sell prices of task
	And I click on Next Button from Scoping Page 
	And I click on Next Button from OtherCosts Page
	And I click on Next Button from CustomerPricing Page
	When I click on Finish Button from CustomerVariables Page
	Then I should see the value of contract

@smoke
Scenario: Verify UI Health by Manually Inserting WBS for General Services for Azure
    Given I Navigate to CPQ UI Page
	And I Enter following Login Details and Click Login Button
		| Username                            | Password       |
		| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "General Services for Azure"
	And I click on Configure Now Button
	And I choose Time & Material from Type of Contract Question
	And I entered Contract Duration in Month as "36"
	And I click on Next Button From Definition Page
	#And I choose "Hours" Option from build your plan Question
	And I click on Add Button to add new Task
	And I Entered Title of the Task as "Task 1"
	And I Entered Efforts of the Task as "100"
	And I selected resource as Consultant as option number "33"
	And I selected country as "India (SWO_IN)" 
	When I click on Confirm Button
	#Then I should see the sell price of the manual Task as "107,243.56"
	Then I Should see the sell prices of task
	And I click on Next Button from Scoping Page 
	And I click on Next Button from OtherCosts Page
	And I click on Next Button from CustomerPricing Page
	When I click on Finish Button from CustomerVariables Page
	Then I should see the value of contract