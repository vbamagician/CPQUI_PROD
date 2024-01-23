Feature: CPQUIMDRForSentinel

This feature aims to ensure the robust UI Health of the MDR for Sentinel 
Solution within the CPQ environment. It focuses on validating the seamless and 
dependable functionality of the user interface while configuring and processing 
a new contract for the MDR for Sentinel.

  @smoke
  Scenario: Verify UI Health while Configuring MDR for Sentinel Solution in CPQ
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
		And I click the "Get Contract" button associated with the reference text "MDR for Sentinel"
		And I choose "Yes" from the radio button group for the question "Do you need any additional standard data sources/connectors to be onboarded to MDR Sentinel apart from the 5 standard data sources/connectors being provided as part of the standard build?"
		And I choose "Yes" from the radio button group for the question "Do you need any Custom data sources/connectors to be onboarded to MDR Sentinel?"
		And I choose "Yes" from the radio button group for the question "Do you need any Custom use cases to be onboarded to MDR Sentinel?"
		And I choose "Yes" from the radio button group for the question "Do you need to integrate any ITSM Tool (JIRA/ServiceNow) with MDR Sentinel apart from the one that SoftwareONE uses?"
		And I choose "Yes" from the radio button group for the question "Do you need to integrate any Third-Party EDR Tool with MDR Sentinel?"
		And I choose "Yes" from the radio button group for the question "Do you need a forensic analysis package for MDR Sentinel?"
		#definition page
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
		And I choose "xDC Gurugram" from the dropdown for the question "Please provide your preferred Delivery Center:"
		And I enter "1" into the textbox for the question "Number of identities?"
		And I enter "1" into the textbox for the question "Number of Additional Standard Data Sources to be Onboarded?"
		And I enter "1" into the textbox for the question "Number of Custom Data Sources/Connectors to be Onboarded?"
		And I enter "1" into the textbox for the question "Number of Custom Use Cases to be Onboarded?"
		And I enter "1" into the textbox for the question "Number of Forensic Package Hours needed?"
		And I enter "1" into the textbox for the question "Number of Third-Party EDR tool to be Integrated?"
		And I enter "1" into the textbox for the question "Number of ITSM Tools to be Integrated?" and press "Enter"
		#Scoping Page
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
		#Customer Pricing
		And I click the button with the text "Next" identified by the parent class "heap-next-3"
		And I choose "PDF" from the dropdown for the question "Document Type:"
	#contacts page
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
	Then I should see the value of contract
