Feature: CPQUISecurityPostureAssessment

This feature is dedicated to testing the UI Health of the Security Posture Assessment Solution within the CPQ UI. 
The primary objective is to ensure a consistent and seamless user experience while configuring a new 
contract for the Security Posture Assessment Solution.

  @smoke
  Scenario: Verify UI Health while Configuring Security Posture Assessment Solution in CPQ UI
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
		And I click the "Get Contract" button associated with the reference text "Security Posture Assessment for AWS"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
#Scope Page
		And I enter "100" to the very special textbox that has question "How many AWS Cloud Accounts would the customer like to do a technical assessment?"
		And I choose "Yes" from the radio button group for the question "Does the technology stack utilise any AWS services such as serverless based workloads?"
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
#Customer Pricing Page 
		And I choose "Days" from the radio button group for the question "How would you like to build your plan?"
		And I click the button with the text "Next" identified by the parent class "heap-next-3"
#Questionnaire Page
		And I enter "ABCD" into the textarea for the question "Stakeholders to be interviewed:"
		And I enter "ABCD" into the textarea for the question "AWS Accounts to be reviewed:"
		And I enter "ABCD" into the textarea for the question "Workloads to be reviewed:"
		And I enter "ABCD" into the textarea for the question "Environment to be reviewed:"
		And I enter "ABCD" into the textarea for the question "Compliance and regulatory standards:"
		And I enter "ABCD" into the textarea for the question "Place of Performance:"
		And I enter "ABCD" into the textarea for the question "Other Exclusions:"
		And I click the button with the text "Next" identified by the parent class "heap-next-5"
#Contacts Page
		And I choose "PDF" from the dropdown for the question "Document Type:"
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
#Opportunity Page / Final Page
	Then I should see the value of contract