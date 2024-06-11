Feature: CPQUIAzureSimple

This feature ensures the UI Health of the Azure Simple Service in the CPQ.

@smoke
Scenario: Verify UI Health while Configuring AzureSimple Service
	Given I Navigate to CPQ UI Page
		And I Enter following Login Details and Click Login Button
			| Username                            | Password        |
			| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
		And I click the button containing the text "New Contract"
		And I enter "walmart" into the textbox with the header labeled "Select an Account" and press "Enter"
		And I check the "asynchronous" checkbox based on the adjacent table has index "1" having cell that has value "00001614"
		And I click the button containing the text "Do you want to continue without an Opportunity?"
		And I enter "UI Test" into the textbox for the question "Draft topic:"
		And I check the "synchronous" checkbox based on the adjacent table has index "3" having cell that has value "Idris Elba"
		And I click the button containing the text "I Confirm"
		And I click the "Get Contract" button associated with the reference text "AzureSimple"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
	#Scope Page
		And I enter "7000000" into the textbox for the question "Estimated Consumption per month"
		And I choose "No" from the radio button group for the question "Are you providing your customer any discount on the estimated consumption?"
		And I choose "No" from the radio button group for the question "Does the customer have an existing account to transfer?"
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
	#Customer Pricing Page
		And I click the button with the text "Next" identified by the parent class "heap-next-3"
	#Questionnaire Page
		And I click the element contains the text "Add"
		And I enter "ABCD" into the textbox for the question "Tenant name:"
		And I choose "Non-Production" from the radio button group for the question "Production or non-production?"
		And I enter "ABCD" into the textbox for the question "Subscription ID:"
		And I click the element contains the text "Save & Add another"
		And I click to close the form "Add Tenant"
		And I enter "60000" into the textbox for the question "Amount:"
		And I click the button with the text "Next" identified by the parent class "heap-next-5"
	#Contacts Page 
		And I choose "PDF" from the dropdown for the question "Document Type:"
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
#Opportunity Page 
	Then I should see the value of contract