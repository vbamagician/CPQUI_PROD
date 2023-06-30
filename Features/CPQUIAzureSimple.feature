Feature: CPQUIAzureSimple

This Feature will test the UI Statbility for Azure Simple Service in CPQ UI

@smoke
Scenario: Test AzureSimple UI Stability On CPQ UI
	Given I Navigate to CPQ UI Page "https://contracts.softwareone.com/login/secondary-login"
	#And I Enter Login Credentials
	And I Enter following Login Details and Click Login Button
		| Username                            | Password                 |
		| helpdesk-scg.global@softwareone.com | lT60VQvBz3RcY3LSPPikPg== |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "AzureSimple"
	And I entered estimated consumption per month value as 7000000
	And I choose no discount
	And I choose customer have existing account to transfer
	And I click Next on Scope Page
	And I click Next Customer Pricing Page
	And I click Next Margin As Sold Page
	And I Add Microsoft Tenant
	And I entered prepayment amount as 60000
	And I click Next on Questionaire Page
	And I Add Authorized Contacts
	And I add Softwareone Contacts
	And I Select Document Type as PDF
	When I click Finish on Contacts Page
	Then I should see the value of contract would be "EUR 84,000,000.00"