Feature: CPQUICloudAccelerationStarterPackForAzure

This feature aims to ensure the robust UI Health of the Cloud Acceleration Starter Pack (for Azure) 
Solution within the CPQ environment. It focuses on validating the seamless and 
dependable functionality of the user interface while configuring and processing 
a new contract for the Cloud Acceleration Starter Pack tailored for Azure.

  @smoke
  Scenario: Verify UI Health while Configuring Cloud Acceleration Starter Pack for Azure Solution in CPQ
	Given I Navigate to CPQ UI Page
		And I Enter following Login Details and Click Login Button
			| Username                            | Password        |
			| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
		And I click on New Contract Button
		And I configure client details for new Contract
		And I click on Specific Service "Cloud Acceleration Starter Pack (for Azure)"
		And I click on Configure Now Button
		And I choose "Azure Migrate" from the radio button group for the question "Preferred Discovery Tool:"
		And I choose "xDC Gurugram" from the radio button group for the question "Remote Delivery Team:"
		And I choose "xDC Gurugram" from the radio button group for the question "Local Delivery Location:"
		And I click on Next button from definition page
		And I enter "10" into the textbox for the question "Number of Servers:"
		And I enter "5" into the textbox for the question "Estimated duration (weeks):"
		And I enter "1" into the textbox for the question "Additional Local Project Manager Effort (Days):"
		And I enter "1" into the textbox for the question "Additional Remote Project Manager Effort (Days):"
		And I enter "1" into the textbox for the question "Additional Local Delivery Effort (Days):"
		And I enter "1" into the textbox for the question "Additional Remote Delivery Effort (Days):"
		And I enter "5000" into the textbox for the question "Business Volume:"
		And I click on Next button from scope page
		And I click on Next button from customer pricing page
		And I enter "ABCD" into the textbox for the question "Azure Tenant Info:"
		And I enter "ABCD" into the textbox for the question "Azure Subscription Info:"
		And I click on Next button from questionnaire page
		And I Select Document Type as PDF
		And I Add Authorized Contacts
		And I add Softwareone Contacts
	When I click Finish on Contacts Page
	Then I should see the value of contract