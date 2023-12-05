Feature: CPQUIDigitalWorkplaceEssentialsForEA

This feature aims to ensure the robust UI Health of the Digital Workplace Essentials for EA 
Solution within the CPQ environment. It focuses on validating the seamless and 
dependable functionality of the user interface while configuring and processing 
a new contract for the Digital Workplace Essentials for EA.

  @smoke
  Scenario: Verify UI Health while Configuring Digital Workplace Essentials for EA Solution in CPQ
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
		And I click the "Get Contract" button associated with the reference text "Digital Workplace Essentials for EA"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
		And I choose "Monthly" from the radio button group for the question "Billing Type"
		And I choose "Yes" from the radio button group for the question "Service Success Manager – SSM (Includes 365 Analytics)"
		And I choose "Yes" from the radio button group for the question "Adoption Change Management"
		#definition page
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
		And I enter "100" into the textbox for the question "Number of Users for which SoftwareOne needs to Provide Support:"
		And I enter "20" into the textbox for the question "Sales Price ( per user per month )"
		And I enter "10000" into the textbox for the question "Service Success Manager Add-On Sell Price"
		And I enter "5000" into the textbox for the question "Adoption Change Management Add-On Sell Price" and press "Enter"
		#Scoping Page
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
		#Customer Pricing
		And I click the button with the text "Next" identified by the parent class "heap-next-3"
		And I enter "ABCD" into the textbox for the question "Tenant Name:"
		#Questionnaire Pricing
		And I click the button with the text "Next" identified by the parent class "heap-next-5"
		And I choose "PDF" from the dropdown for the question "Document Type:"
		#contacts page
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
	Then I should see the value of contract