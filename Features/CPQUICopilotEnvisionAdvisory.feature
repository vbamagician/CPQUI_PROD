Feature: CPQUICopilotEnvisionAdvisory

This feature ensures the UI Health of the Copilot Envision Advisory Service in the CPQ.

@smoke
Scenario: Verify UI Health while Configuring Copilot Envision Advisory Service
	Given I Navigate to CPQ UI Page
		And I Login to CPQ using SSO Credentials
		And I click the button containing the text "New Contract"
		And I enter "walmart" into the textbox with the header labeled "Select an Account" and press "Enter"
		And I check the "asynchronous" checkbox based on the adjacent table has index "1" having cell that has value "00001614"
		And I click the button containing the text "Do you want to continue without an Opportunity?"
		And I enter "UI Test" into the textbox for the question "Draft topic:"
		And I check the "synchronous" checkbox based on the adjacent table has index "3" having cell that has value "Idris Elba"
		And I click the button containing the text "I Confirm"
		And I click the "Get Contract" button associated with the reference text "Copilot Envision Advisory"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
		
		#Definition Page
		And I click on Next Button From Definition Page
		
		#Scoping Page
		And I click on element with attribute "class" and value "kk-action-menu-trigger" on the adjacent table has text "Project initiation" 
		And I click the button containing the text "Edit" on the adjacent table has text "Project initiation" 
		And I choose "xDC Gurugram" from the dropdown for the question "Country:"
		And I click the button containing the text "Confirm"
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
		
	When I click Finish on Contacts Page
	Then I should see the value of contract