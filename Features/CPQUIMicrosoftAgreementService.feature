Feature: CPQUIMicrosoftAgreementService

This Feature will test the UI Statbility for Microsoft Agreement Service in CPQ UI PROD

@smoke
Scenario: Test MS Agreement UI Stability in CPQ UI PROD
	Given I Navigate to CPQ UI Page "https://contracts.softwareone.com/login/secondary-login"
	And I Enter following Login Details and Click Login Button
		| Username                            | Password                 |
		| helpdesk-scg.global@softwareone.com | lT60VQvBz3RcY3LSPPikPg== |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "Microsoft Agreement Service"
	And I select Pack Managed LSP Checkbox
	And I click on Next Button From Definition Page for MSA
	And I click on Add Buton to mention Agreemnt that customer going to sign with Microsoft
	And I choose Enrollment Type as EA
	And I choose Price Level as A
	And I enter Annual Amount as "10000"
	And I click on Submit Button
	And I click Next on Scope Page for MSA
	And I click Next Customer Pricing Page for MSA
	And I click Next Margin As Sold Page for MSA
	And I choose Remote option for FinOps Fundamentals and KickOff
	And I choose Remote option for Spend Management Implementation or Onboarding
	And I choose Remote option for PyraCloud Spend Management Training
	And I choose Remote option for Cloud Cost Optimization Implementation
	And I click Next on Questionaire Page for MSA
	And I Add Authorized Contacts
	And I add Softwareone Contacts
	And I Select Document Type as PDF
	When I click Finish on Contacts Page for MSA
	Then I should see the value of contract would be "EUR 4,690.51"