Feature: CPQUIMicrosoftAgreementService

This feature is dedicated to testing the UI Health of the Microsoft Agreement Service within the CPQ UI. 
The primary objective is to ensure a consistent and seamless user experience while configuring a new 
contract for the Microsoft Agreement Service.

  @smoke
  Scenario: Verify UI Health while Configuring Microsoft Agreement Service in CPQ UI
	Given I Navigate to CPQ UI Page
		And I Enter following Login Details and Click Login Button
			| Username                            | Password                 |
			| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
		And I click on New Contract Button
		And I configure client details for new Contract
		And I click on Service "Microsoft Agreement Service"
		And I click on Configure Now Button
		And I select Pack Managed LSP Checkbox
		And I click on Next Button From Definition Page for MSA
		And I click on Add Buton to mention Agreemnt that customer going to sign with Microsoft
		And I choose Enrollment Type as EA
		And I choose Price Level as A
		And I enter Annual Amount as "10000"
		And I click on Submit Button
		And I click Next on Scope Page for MSA
		And I click Next Customer Pricing Page for MSA
		And I choose Remote option for FinOps Fundamentals and KickOff
		And I choose Remote option for Spend Management Implementation or Onboarding
		And I choose Remote option for PyraCloud Spend Management Training
		And I choose Remote option for Cloud Cost Optimization Implementation
		And I click Next on Questionaire Page for MSA
		And I Select Document Type as PDF
		And I Add Authorized Contacts
		And I add Softwareone Contacts
	When I click Finish on Contacts Page for MSA
	Then I should see the value of contract