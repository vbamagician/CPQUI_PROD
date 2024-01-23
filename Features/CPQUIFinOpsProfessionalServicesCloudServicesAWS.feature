Feature: CPQUIFinOpsProfessionalServicesCloudServicesAWS

This feature aims to ensure the robust UI Health of the FinOps Professional Services - Cloud Services AWS 
Solution within the CPQ environment. It focuses on validating the seamless and 
dependable functionality of the user interface while configuring and processing 
a new contract for the Digital Workplace Essentials for EA.

  @smoke
  Scenario: Verify UI Health while Configuring FinOps Professional Services - Cloud Services AWS Solution in CPQ
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
		And I click the "Get Contract" button associated with the reference text "FinOps Professional Services - Cloud Services AWS"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
		And I choose the radio button option "Apptio Cloudability" specifically
		And I check "Azure" checkbox for the header "Please select Cloud Providers in-scope"
		And I check "AWS" checkbox for the header "Please select Cloud Providers in-scope"
		And I choose "Yes" from the radio button group for the question "FinOps Fundamentals Workshop (Kick Off)"
		And I choose "Yes" from the radio button group for the question "FinOps Diagnostic Assessment"
		And I choose "Yes" from the radio button group for the question "Cloud Cost Optimization Fundamentals Workshop (Proof of Value)"
		And I choose "Yes" from the radio button group for the question "Cloud Spend Management Implementation for Cloudability"
		And I choose "Yes" from the radio button group for the question "Cloud Sustainability Fundamentals Workshop"
		And I choose "Yes" from the radio button group for the question "Project Management"
		#definition page
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
		And I choose "xDC Gurugram" from the dropdown for the question "Please provide your preferred Delivery Center:"
		And I choose "Associate Consultant" from the radio button group for the question "Consultant Level:"
		And I enter "1" into the textbox for the question "Number of subscriptions?"
		And I enter "10000" into the textbox for the question "Estimated Annual Cloud Spend" having repeat index of "1" and press "Nothing"
		And I enter "1" into the textbox for the question "Number of accounts?"		
		And I enter "10000" into the textbox for the question "Estimated Annual Cloud Spend" having repeat index of "2" and press "Nothing"
		And I enter "20000" into the textbox for the question "Business Volume:" and press "Enter"
		#Scoping Page
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
		#Customer Pricing
		And I click the button with the text "Next" identified by the parent class "heap-next-3"
		And I enter "ABCD" into the textarea for the question "Locations in scope:"
		And I enter "ABCD" into the textarea for the question "Organizations in scope:"
		#Questionnaire Pricing
		And I click the button with the text "Next" identified by the parent class "heap-next-5"
		And I choose "PDF" from the dropdown for the question "Document Type:"
		#contacts page
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
	Then I should see the value of contract