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
		And I click the button containing the text "New Contract"
		And I enter "walmart" into the textbox with the header labeled "Select an Account" and press "Enter"
		And I check the "asynchronous" checkbox based on the adjacent table has index "1" having cell that has value "00001614"
		And I click the button containing the text "Do you want to continue without an Opportunity?"
		And I enter "UI Test" into the textbox for the question "Draft topic:"
		And I check the "synchronous" checkbox based on the adjacent table has index "3" having cell that has value "Idris Elba"
		And I click the button containing the text "I Confirm"
		And I click the "Get Contract" button associated with the reference text "Cloud Managed Services for AWS"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
#definition page
		And I choose "No" from the radio button group for the question "AWS Advanced"
		And I choose "No" from the radio button group for the question "AWS Premium"
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
#Scoping Page
		And I enter "10" into the textbox for the question "Number of AWS Accounts:"
		And I enter "12000" into the textbox for the question "Estimated Total Consumption per month"
		And I choose "No" from the radio button group for the question "Is a discount required to close this deal?"
		And I choose "No" from the radio button group for the question "Does the customer has an exsiting AWS Account to transfer?"
		And I choose "New 'Commercial Account' to be setup by SWO" from dropdown box of a question "Please select from one of the following options:"
		And I choose "Standard Support" from radio button group of a question "Standard or Enterprise Support?"
		And I choose the radio button option "AWS Led Support" specifically
		And I choose "AWS Led Development Support" from radio button group of a question "Level of Support:"
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
#Customer Pricing
		And I click the button with the text "Next" identified by the parent class "heap-next-3"
#Questionnaire Pricing
		And I choose "No" from radio button group of a question "Does the customer agree to have one consolidated SoftwareONE invoice for all spend?"
		And I choose "No" from radio button group of a question "Do you have the customer billing requirements?"
		And I choose "Service Provider Account Model (SPAM)" from radio button group of a question "What should be the target account model?"
		And I choose "No" from radio button group of a question "Are additional AWS Linked/Member accounts required?"
		And I click the button with the text "Next" identified by the parent class "heap-next-5"
#contacts page
		And I choose "PDF" from the dropdown for the question "Document Type:"
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
#opportunity Page 
	Then I should see the value of contract
