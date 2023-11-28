Feature: CPQUIAzureSimple

This Feature will test the UI Statbility for Azure Simple Service in CPQ UI

@smoke
Scenario: Test AzureSimple UI Stability On CPQ UI
	Given I Navigate to CPQ UI Page
	#And I Enter Login Credentials
	And I Enter following Login Details and Click Login Button
		| Username                            | Password        |
		| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "AzureSimple"
	And I click on Configure Now Button
	And I entered estimated consumption per month value as 7000000
	And I choose no discount
	And I choose customer have existing account to transfer
	And I click Next on Scope Page
	And I click Next Customer Pricing Page
	#And I click Next Margin As Sold Page
	And I Add Microsoft Tenant
	And I entered prepayment amount as 60000
	And I click Next on Questionaire Page
	And I Select Document Type as PDF
	And I Add Authorized Contacts
	And I add Softwareone Contacts
	When I click Finish on Contacts Page
	Then I should see the value of contract