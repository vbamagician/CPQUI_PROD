Feature: CPQUIDSCAdvanced

This feature focuses on testing the UI Health of the DSC Advanced Solution within 
the CPQ environment. The primary objective is to ensure a reliable and smooth user interface 
experience while configuring a new contract for DSC Advanced Solution.

  @smoke
  Scenario: Verify UI Health while Configuring DSC Advanced Solution in CPQ
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
		And I click the "Get Contract" button associated with the reference text "DSC Advanced"
		And I click on Configure Now Button
		And I choose the radio button option "New Customer" specifically
		And I choose "Yes" from the radio button group for the question "Service Operational Design and Planning for Sourcing:"
		And I choose "Yes" from the radio button group for the question "DSC Advanced Core"
		And I choose "Yes" from the radio button group for the question "Product Evaluation"
		And I choose "Yes" from the radio button group for the question "License Availability Checks"
		And I choose "Yes" from the radio button group for the question "Standardization Enforcement"
		And I choose "Yes" from the radio button group for the question "Demand Management for Renewals"
		And I choose "Yes" from the radio button group for the question "EULA Check Managed Service"
		#definition page
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
		And I choose "xDC Gurugram" from the dropdown for the question "Please provide your preferred Delivery Center:"
		And I choose "12" from the radio button group for the question "Contract duration (months):"
		And I enter "100" into the textbox for the question "Number of total IT User count?" and press "Enter"
		#Scoping Page
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
		#Customer Pricing
		And I click the button with the text "Next" identified by the parent class "heap-next-3"
		#Questionnaire Page
		And I click the button with the text "Next" identified by the parent class "heap-next-5"
		And I choose "PDF" from the dropdown for the question "Document Type:"
	#contacts page
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
	Then I should see the value of contract
