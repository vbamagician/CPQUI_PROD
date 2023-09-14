Feature: CPQUIMarginAsSoldService

This Feature will test the UI Statbility for Services which only have Margin As Sold Configuration 

@smoke
Scenario: I test UI Statbility of MAS Based service
	Given I Navigate to CPQ UI Page
	And I Enter following Login Details and Click Login Button
		| Username                            | Password                 |
		| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "Office 365 Mail Transition"
	And I Enter Business Volume for MAS as "1000000"
	And I Enter License Cost for MAS as "20000"
	And I Enter Third Party Delivery Cost for MAS as "10000"
	And I Enter Internal Deliveyr Cost for MAS as "500000"
	When I Click on Next Button from MAS Page
	Then I should see the value of contract