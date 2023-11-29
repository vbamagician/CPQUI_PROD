Feature: CPQUIDevOpsMaturityAssessment

This feature aims to test the UI Health of the DevOps Maturity Assessment Solution in CPQ. 
The primary goal is to ensure a robust and seamless user interface experience while configuring
a new contract for the DevOps Maturity Assessment tailored for AWS.

  @smoke
  Scenario: Verify UI Health while Configuring DevOps Maturity Assessment Solution in CPQ
   	Given I Navigate to CPQ UI Page
	And I Enter following Login Details and Click Login Button
		| Username                            | Password        |
		| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "DevOps Maturity Assessment for AWS"
	And I click on Configure Now Button
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
