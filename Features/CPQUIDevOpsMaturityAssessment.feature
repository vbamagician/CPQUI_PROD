Feature: CPQUIDevOpsMaturityAssessment

this feature will test the UI stability of DevOps Maturity Assessment Solution in CPQ

@tag1
Scenario: Test DevOps Maturity Assessment Solution in CPQ
	Given I Navigate to CPQ UI Page
	And I Enter following Login Details and Click Login Button
		| Username                            | Password        |
		| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "DevOps Maturity Assessment for AWS"
	And I choose option "Yes" for a question "Is this a complex environment?"
	And I choose option "Yes" for a question "Is the complexity for People and Process?"
	And I choose option "Yes" for a question "Is the complexity for Process and Technology?"
	And I click on Next button from scope page for DMA
	And I click on Next button from Customer Pricing page for DMA
	#And I click on Next button from Margin As Sold Page for DMA
	And I Select Document Type as PDF
	And I Add Authorized Contacts
	And I add Softwareone Contacts
	When I click Finish on Contacts Page
	Then I should see the value of contract
