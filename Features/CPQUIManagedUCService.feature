﻿Feature: CPQUIManagedUCService

This feature is dedicated to testing the UI Health of the Managed UC Service within the CPQ UI. 
The primary objective is to ensure a consistent and seamless user experience while configuring a new 
contract for the Unified Communications Managed Service.

  @smoke
  Scenario: Verify UI Health while Configuring Managed UC Service in CPQ UI
    Given I Navigate to CPQ UI Page
		And I Enter following Login Details and Click Login Button
			| Username                            | Password        |
			| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
		And I click on New Contract Button
		And I configure client details for new Contract
		And I click on Service "Unified Communications Managed Service"
		And I click on Configure Now Button
		And I select option Managed Unified Communications Voice for Optional Services
		And I select option Yes for Is Voice Infrastructure support required
		And I select option No for Is Call Route required
		And I click on Next Button From Definition Page for MUC
		And I choose option three Year for Agreement Term
		And I entered hundred as Number of Users
		And I entered hundred as Number of Devices
		And I click Next on Scope Page for MUC
		And I click on Next Button from Customer Pricing Page for MUC
		And I entered name as random value for Microsoft Office Tenant
		And I click on Next Button from Questionnaire Page for MUC
		And I Select Document Type as PDF
		And I Add Authorized Contacts
		And I add Softwareone Contacts
	When I click Finish on Contacts Page
	Then I should see the value of contract