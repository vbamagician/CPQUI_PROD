Feature: CPQUICloudManagedServiceForAWS

This feature focuses on testing the UI Health of the Cloud Managed Service for AWS within the CPQ environment. 
The objective is to ensure a reliable and seamless user interface experience while configuring a 
new contract for Cloud Managed Services tailored for AWS.

  @smoke
  Scenario: Verify UI Health while Configuring Cloud Managed Service for AWS in CPQ
    Given I Navigate to CPQ UI Page
		And I Enter following Login Details and Click Login Button
			| Username                            | Password        |
			| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
		And I click on New Contract Button
		And I configure client details for new Contract
		And I click on Service "Cloud Managed Services for AWS"
		And I click on Configure Now Button
		And I choose "No" from the radio button group for the question "AWS Advanced"
		And I choose "No" from the radio button group for the question "AWS Premium"
		And I click on Next button from definition page for CMSAWS
		And I enter "12000" into the textbox for the question "Estimated Total Consumption per month"
		And I choose "No" from the radio button group for the question "Is a discount required to close this deal?"
		And I enter "1" into the textbox for the question "Number of AWS Accounts:"
		And I choose "No" from the radio button group for the question "Does the customer has an exsiting AWS Account to transfer?"
		And I choose "New 'Commercial Account' to be setup by SWO" from dropdown box of a question "Please select from one of the following options:"
		And I choose "Standard Support" from radio button group of a question "Standard or Enterprise Support?"
		And I choose "AWS Led Basic Support" from radio button group of a question "Level of Support:"
		And I click on Next button from scope page for CMSAWS
		And I click on Next button from customer pricing page for CMSAWS
		And I entered "ABC123" in a textbox of a question "SCU Number:"
		And I choose "No" from radio button group of a question "Do they need split billing?"
		And I choose "Service Provider Account Model (SPAM)" from radio button group of a question "What should be the target account model?"
		And I entered "ABCD" in a textbox of a question "Account ID:"
		And I entered "a@gmail.com" in a textbox of a question "Owner Email:"
		And I choose "No" from radio button group of a question "Any workload provisioned in Master Payer Account?"
		And I click on Next button from customer questionnaire page for CMSAWS
		And I Select Document Type as PDF
	When I click Finish on Contacts Page
	Then I should see the value of contract
