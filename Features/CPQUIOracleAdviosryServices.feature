Feature: CPQUIOracleAdviosryServices

This feature will test UI stability of Oracle Advisory Services Solution in CPQ

@smoke
Scenario: Test Oracle Advisory Services Solution in CPQ
	Given I Navigate to CPQ UI Page
	And I Enter following Login Details and Click Login Button
		| Username                            | Password        |
		| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Specific Service "Oracle Advisory Services"
	And I click on Configure Now Button
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
	And I choose "Yes" from the radio button group for the question "Local Project Management?"
	And I click on Next button from definition page for OAS
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
	And I enter "50" into the textbox for the question Number of hours for the "Local Project Management"
	And I click on Next button from scope page for OAS
	And I click on Next button from customer pricing page for OAS
	And I enter "ABCD" into the textarea for the question "Locations in scope:"
	And I enter "ABCD" into the textarea for the question "Organizations in scope:"
	And I enter "ABCD" into the textarea for the question "Inventory tools in scope:"
	And I click on Next button from customer questionnaire page for OAS
	And I Select Document Type as PDF
	And I Add Authorized Contacts
	And I add Softwareone Contacts
	When I click Finish on Contacts Page
	Then I should see the value of contract