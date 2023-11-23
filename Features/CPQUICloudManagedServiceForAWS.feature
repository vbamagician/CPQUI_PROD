Feature: CPQUICloudManagedServiceForAWS

This feature will test UI stability of Cloud Managed Service for AWS in CPQ

@smoke
Scenario: Test Cloud Managed Service for AWS in CPQ
	Given I Navigate to CPQ UI Page
	And I Enter following Login Details and Click Login Button
		| Username                            | Password        |
		| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "Cloud Managed Services for AWS"
	And I select option as "Essentials" from available Services Tiers in scope
	And I click on Next button from definition page for CMSAWS
	And I entered "12000" in a textbox of a question "Estimated Total Consumption per month"
	And I entered "1" in a textbox of a question "Number of AWS Accounts"
	And I choose "No" from radio button group of a question "Does the customer has an exsiting AWS Account to transfer?"
	And I choose "New 'Commercial Account' to be setup by SWO" from dropdown box of a question "Please select from one of the following options:"
	And I choose "Standard Support" from radio button group of a question "Standard or Enterprise Support?"
	And I choose "AWS Led Basic Support" from radio button group of a question "Level of Support:"
	And I click on Next button from scope page for CMSAWS
	And I click on Next button from customer pricing page for CMSAWS
	And I entered "ABC123" in a textbox of a question "SCU Number:"
	And I choose "No" from radio button group of a question "Do they need split billing?"
	And I entered "ABCD" in a textbox of a question "Customer PO for monthly billing:"
	And I choose "Service Provider Account Model (SPAM)" from radio button group of a question "What should be the target account model?"
	And I entered "ABCD" in a textbox of a question "Account ID:"
	And I entered "a@gmail.com" in a textbox of a question "Owner Email:"
	And I choose "No" from radio button group of a question "Any workload provisioned in Master Payer Account?"
	And I click on Next button from customer questionnaire page for CMSAWS
	And I Select Document Type as PDF
	And I Add Authorized Contacts
	And I add Softwareone Contacts
	When I click Finish on Contacts Page
	Then I should see the value of contract
