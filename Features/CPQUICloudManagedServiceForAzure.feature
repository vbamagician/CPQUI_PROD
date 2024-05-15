Feature: CPQUICloudManagedServiceForAzure

This feature focuses on testing the UI Health of the Cloud Managed Service for Azure within 
the CPQ environment. The primary objective is to ensure a reliable and smooth user interface 
experience while configuring a new contract for Cloud Managed Services tailored specifically for Azure.

  @smoke
  Scenario: Verify UI Health while Configuring Cloud Managed Service for Azure in CPQ
    Given I Navigate to CPQ UI Page
		And I Enter following Login Details and Click Login Button
			| Username                            | Password        |
			| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
		And I click the button containing the text "New Contract"
		And I enter "walmart" into the textbox with the header labeled "Select an Account" and press "Enter"
		And I check the "asynchronous" checkbox based on the adjacent table has index "1" having cell that has value "00001614"
		And I click the button containing the text "Do you want to continue without an Opportunity?"
		And I enter "UI Test" into the textbox for the question "Draft topic:"
		And I check the "synchronous" checkbox based on the adjacent table has index "3" having cell that has value "Idris Elba"
		And I click the button containing the text "I Confirm"
		And I click the "Get Contract" button associated with the reference text "Cloud Managed Services for Azure"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
#definition page
		And I choose "Yes" from the radio button group for the question "Azure Essentials for CSP?"
		And I choose "Yes" from the radio button group for the question "Azure Essentials for EA?"
		And I choose "Yes" from the radio button group for the question "Azure Advanced?"
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
#Scoping Page
		And I enter "1" into the textbox for the question "Discount %" having repeat index of "1" and press "Nothing"
		And I enter "1" into the textbox for the question "Discount %" having repeat index of "2" and press "Nothing"
		And I enter "1" into the textbox for the question "Discount %" having repeat index of "3" and press "Nothing"
	#Azure Essentials for CSP	
		And I enter "12000" into the textbox for the question "Estimated Consumption per month" having repeat index of "1" and press "Nothing"
	#Azure Essentials for EA	
		And I enter "11000" into the textbox for the question "Estimated Consumption per month" having repeat index of "2" and press "Nothing"
	#Azure Advanced
		And I enter "10000" into the textbox for the question "Estimated Consumption per month" having repeat index of "3" and press "Nothing"
		And I check the "synchronous" checkbox based on the adjacent table has index "5" having cell that has value "Transfer from Indirect SCE / Enterprise Agreement, Web Direct (PAYG), Open or MPSA (via Staging Subscription)"
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
#Customer Pricing
		And I click the button with the text "Next" identified by the parent class "heap-next-3"
#Contacts page
		And I choose "PDF" from the dropdown for the question "Document Type:"
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
#Opportunity Page 
	Then I should see the value of contract