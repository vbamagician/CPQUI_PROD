Feature: CPQUIServicesCalculatorExcel

This feature is dedicated to testing the UI Health of the Excel Based Services Calculator Configurator within the CPQ UI. 
The primary objective is to ensure a consistent and seamless user experience while configuring a new 
contract for the Services Calculator Based Excel Configurator.

  @smoke
  Scenario: Verify UI Health while Configuring Excel Based Services Calculator Configurator in CPQ UI
	Given I navigate to the page using the environment variable "CPQUI_PAGE_LINK"
		And I click the button containing the text "Login"
		And I enter "CPQUI_LOGIN_USERNAME" from environment into the element "input" of having attribute "name" having the value "loginfmt"
		And I click the element "input" of having attribute "value" having the value "Next"
		And I enter "CPQUI_LOGIN_PASSWORD" from environment into the element "input" of having attribute "name" having the value "passwd"
		And I click the element "input" of having attribute "value" having the value "Sign in"
		And I click the element "input" of having attribute "value" having the value "Yes"
		And I click the button containing the text "New Contract"
		And I enter "walmart" into the textbox with the header labeled "Select an Account" and press "Enter"
		And I check the "asynchronous" checkbox based on the adjacent table has index "1" having cell that has value "00001614"
		And I click the button containing the text "Do you want to continue without an Opportunity?"
		And I enter "UI Test" into the textbox for the question "Draft topic:"
		And I check the "synchronous" checkbox based on the adjacent table has index "3" having cell that has value "Idris Elba"
		And I click the button containing the text "I Confirm"
		And I click the "Get Contract" button associated with the reference text "Unified Support for Azure"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
		And I click the button containing the text "Download" Then the file "MAS Data - Unified Support for Azure.xlsb" should be downloaded and saved
		And I click the button containing the text "Close"
		And I click the button containing the text "Upload"
		And I click the button containing the text "Choose files" to upload the file "MAS Data - Unified Support for Azure.xlsb" from the path "..\..\..\Support\" 
		And I click the element contains the text "Upload Document"
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
	Then I should see the value of contract