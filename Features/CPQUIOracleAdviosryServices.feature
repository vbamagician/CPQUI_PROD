Feature: CPQUIOracleAdviosryServices

This feature is dedicated to testing the UI Health of the Oracle Adviosry Services within the CPQ UI. 
The primary objective is to ensure a consistent and seamless user experience while configuring a new 
contract for the Oracle Adviosry Services.

  @smoke
  Scenario: Verify UI Health while Configuring Oracle Adviosry Services in CPQ UI
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
		And I click the "Get Contract" button associated with the reference text "Oracle Advisory Services"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
#definition page
		And I choose "Yes" from the radio button group for the question "Database and Middleware?"
		And I choose "Yes" from the radio button group for the question "E-Business Suite Production?"
		And I choose "Yes" from the radio button group for the question "Siebel?"
		And I choose "Yes" from the radio button group for the question "Hyperion?"
		And I choose "Yes" from the radio button group for the question "Primavera?"
		And I choose "Yes" from the radio button group for the question "JD Edwards?"
		And I choose "Yes" from the radio button group for the question "Peoplesoft?"
		And I choose "Yes" from the radio button group for the question "Agile?"
		And I choose "Yes" from the radio button group for the question "Fusion Cloud?"
		And I choose "Yes" from the radio button group for the question "Business Intelligence?"
		And I choose "Yes" from the radio button group for the question "Golden Gate?"
		And I choose "Yes" from the radio button group for the question "Identity Access Management?"
		And I choose "No" from the radio button group for the question "Other Products?"
		And I choose "Yes" from the radio button group for the question "Oracle Audit Support?"
		And I choose "Yes" from the radio button group for the question "Oracle Negotiation Support?"
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
#scope page
		And I enter "1" into the textbox for the question Number of documents for the "Oracle Entitlements Analysis"
		And I enter "1" into the textbox for the question Number of servers for the "Database and Middleware"
		And I enter "1" into the textbox for the question Number of environments for the "E-Business Suite Production"
		And I enter "1" into the textbox for the question Number of environments for the "Siebel"
		And I enter "1" into the textbox for the question Number of environments for the "Hyperion"
		And I enter "1" into the textbox for the question Number of environments for the "Primavera"
		And I enter "1" into the textbox for the question Number of environments for the "Peoplesoft"
		And I enter "1" into the textbox for the question Number of environments for the "Agile"
		And I enter "1" into the textbox for the question Number of environments for the "Fusion Cloud"
		And I enter "1" into the textbox for the question Number of environments for the "Business Intelligence"
		And I enter "1" into the textbox for the question Number of targets & sources for the "GoldenGate"
		And I enter "1" into the textbox for the question Number of users for the "Identity & Access Management"
		And I enter "50" into the textbox for the question Number of hours for the "Oracle Audit Support"
		And I enter "50" into the textbox for the question Number of hours for the "Oracle Negotiation Support"
		And I enter "50" into the textbox for the question Number of hours for the "Oracle Remediation and Optimization"
		And I choose "3" from the radio button group for the question "Audit and/or Negotiation support hours need to be consumed within"
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
#customer pricing page
		And I click the button with the text "Next" identified by the parent class "heap-next-3"
#questionnaire page
		And I enter "ABCD" into the textarea for the question "Locations in scope:"
		And I enter "ABCD" into the textarea for the question "Organizations in scope:"
		And I enter "ABCD" into the textarea for the question "Inventory tools in scope:"
		And I click the button with the text "Next" identified by the parent class "heap-next-5"
#contacts page
		And I choose "PDF" from the dropdown for the question "Document Type:"
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
	Then I should see the value of contract