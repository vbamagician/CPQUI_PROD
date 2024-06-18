Feature: CPQUIMarginAsSoldService

This feature is dedicated to testing the UI Health of the Margin As Sold Service within the CPQ UI. 
The primary objective is to ensure a consistent and seamless user experience while configuring a new 
contract for the Margin As Sold Service.

  @smoke
  Scenario: Verify UI Health while Configuring Margin As Sold Service in CPQ UI
	Given I Navigate to CPQ UI Page
		And I Enter following Login Details and Click Login Button
		| Username                            | Password		|
		| helpdesk-scg.global@softwareone.com | CPQ.account1708	|
		And I click the button containing the text "New Contract"
		And I enter "walmart" into the textbox with the header labeled "Select an Account" and press "Enter"
		And I check the "asynchronous" checkbox based on the adjacent table has index "1" having cell that has value "00001614"
		And I click the button containing the text "Do you want to continue without an Opportunity?"
		And I enter "UI Test" into the textbox for the question "Draft topic:"
		And I check the "synchronous" checkbox based on the adjacent table has index "3" having cell that has value "Idris Elba"
		And I click the button containing the text "I Confirm"
		And I click the "Get Contract" button associated with the reference text "License Desk - Local"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
#Margin As Sold Page 
		And I enter "1000000" into the textbox for the question "Business Volume:"
		And I enter "125000" into the textbox for the question "License Cost:"
		And I enter "25000" into the textbox for the question "Third Party Delivery Cost:"
		And I enter "200000" into the textbox for the question "Internal Delivery Cost:"
		When I click the button with the text "Next" identified by the parent class "heap-next-4"
#Opportunity Page 
	Then I should see the value of contract