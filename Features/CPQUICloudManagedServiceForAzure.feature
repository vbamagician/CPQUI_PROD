Feature: CPQUICloudManagedServiceForAzure

This feature will test UI stability of Cloud Managed Service for Azure in CPQ

@tag1
Scenario: Test Cloud Managed Service for Azure in CPQ
	Given I Navigate to CPQ UI Page
	And I Enter following Login Details and Click Login Button
		| Username                            | Password        |
		| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "Cloud Managed Services for Azure"
	And I select option as "Yes" for service selection of Azure Essential for CSP
	And I select option as "Yes" for service selection of Azure Essentials for EA
	And I select option as "Yes" for service selection of Azure Advanced
	And I click on Next button from Definition page for CMSA
	And I entered Estimated Consumption per month for Azure Essential for CSP as "10000"
	And I choose option as "Yes" about offering discount for Azure Essential for CSP
	And I entered discount percentage for Azure Essential for CSP as "5"
	And I entered Estimated Consumption per month for Azure Essentials for EA as "10000"
	And I choose option as "Yes" about offering discount for Azure Essentials for EA
	And I entered discount percentage for Azure Essentials for EA as "5"
	And I entered Estimated Consumption per month for Azure Advanced as "10000"
	And I choose option as "Yes" about offering discount for Azure Advanced
	And I entered discount percentage for Azure Advanced as "5"
	And I select option from dropdown for Azure Account Transfer as New CSP and value is "69119"
	And I click on next button from scope page for CMSA
	And I click on Next button from customer pricing page for CMSA
	And I Select Document Type as PDF
	And I Add Authorized Contacts
	And I add Softwareone Contacts
	When I click Finish on Contacts Page
	Then I should see the value of contract
