Feature: CPQUIProfessionalServicesWizard

This feature ensures the UI Health of the General Services for Azure section in the CPQ Professional Services Wizard. 
It verifies the smooth and reliable functioning of the user interface when selecting options and entering details, 
both through importing and manually inserting WBS.

@smoke
Scenario: Verify UI Health by Importing WBS for General Services for Azure
    Given I Navigate to CPQ UI Page
		And I Enter following Login Details and Click Login Button
			| Username                            | Password        |
			| helpdesk-scg.global@softwareone.com | CPQ.account1708	|
		And I click the button containing the text "New Contract"
		And I enter "walmart" into the textbox with the header labeled "Select an Account" and press "Enter"
		And I check the "asynchronous" checkbox based on the adjacent table has index "1" having cell that has value "00001614"
		And I click the button containing the text "Do you want to continue without an Opportunity?"
		And I enter "UI Test" into the textbox for the question "Draft topic:"
		And I check the "synchronous" checkbox based on the adjacent table has index "3" having cell that has value "Idris Elba"
		And I click the button containing the text "I Confirm"
		And I click the "Get Contract" button associated with the reference text "General Services for Azure"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
#Definition page
		And I choose "Time and Material" from the radio button group for the question "Type of contract:"
		And I enter "36" into the textbox for the question "Contract Duration (months):"
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
#Scope Page 
		And I downloaded the WBS template and saved as "WBSExport.xls"
		And I click on Import Button
		And I click on Choose Files Button and Choose "WBSExport.xls" File
		When I click on Upload Button
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
			| Username                            | Password		|
			| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
		And I click the button containing the text "New Contract"
		And I enter "walmart" into the textbox with the header labeled "Select an Account" and press "Enter"
		And I check the "asynchronous" checkbox based on the adjacent table has index "1" having cell that has value "00001614"
		And I click the button containing the text "Do you want to continue without an Opportunity?"
		And I enter "UI Test" into the textbox for the question "Draft topic:"
		And I check the "synchronous" checkbox based on the adjacent table has index "3" having cell that has value "Idris Elba"
		And I click the button containing the text "I Confirm"
		And I click the "Get Contract" button associated with the reference text "General Services for Azure"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
#Definition page
		And I choose "Time and Material" from the radio button group for the question "Type of contract:"
		And I enter "36" into the textbox for the question "Contract Duration (months):"
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
#Scope Page 
		And I click on Add Button to add new Task
		And I Entered Title of the Task as "Task 1"
		And I Entered Efforts of the Task as "100"
		And I selected resource as Consultant as option number "33"
		And I selected country as "xDC Gurugram" 
		When I click on Confirm Button
		Then I Should see the sell prices of task
		And I click on Next Button from Scoping Page 
		And I click on Next Button from OtherCosts Page
		And I click on Next Button from CustomerPricing Page
	When I click on Finish Button from CustomerVariables Page
	Then I should see the value of contract