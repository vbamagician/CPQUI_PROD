Feature: CPQUICloudStarterPackForAzure

This feature aims to ensure the robust UI Health of the Cloud Starter Pack (for Azure) 
Solution within the CPQ environment. It focuses on validating the seamless and 
dependable functionality of the user interface while configuring and processing 
a new contract for the Cloud Starter Pack tailored for Azure.

  @smoke
  Scenario: Verify UI Health while Configuring Cloud Starter Pack for Azure Solution in CPQ
	#<10>
	#Given I Navigate to CPQ UI Page
	Given I navigate to the page using the environment variable "CPQUI_PAGE_LINK"
	#</10>
	#<11>
		#And I Enter following Login Details and Click Login Button
			#| Username                            | Password        |
			#| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
		And I click the button containing the text "Login"
		And I enter "CPQUI_LOGIN_USERNAME" from environment into the element "input" of having attribute "name" having the value "loginfmt"
		And I click the element "input" of having attribute "value" having the value "Next"
		And I enter "CPQUI_LOGIN_PASSWORD" from environment into the element "input" of having attribute "name" having the value "passwd"
		And I click the element "input" of having attribute "value" having the value "Sign in"
		And I click the element "input" of having attribute "value" having the value "Yes"
	#</11>
	#<1>
		#And I click on New Contract Button
		And I click the button containing the text "New Contract"
	#</1>
	#<2>
		#And I configure client details for new Contract
		And I enter "walmart" into the textbox with the header labeled "Select an Account" and press "Enter"
		And I check the "asynchronous" checkbox based on the adjacent table has index "1" having cell that has value "00001614"
		And I click the button containing the text "Do you want to continue without an Opportunity?"
		And I enter "UI Test" into the textbox for the question "Draft topic:"
		And I check the "synchronous" checkbox based on the adjacent table has index "3" having cell that has value "Idris Elba"
		And I click the button containing the text "I Confirm"
	#</2>
	#<3>
		#And I click on Specific Service "Cloud Starter Pack (for Azure)"
		And I click the "Get Contract" button associated with the reference text "Cloud Starter Pack (for Azure)"
	#</3>
	#<4>
		#And I click on Configure Now Button
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
	#</4>
		And I choose "Azure Migrate" from the radio button group for the question "Preferred Discovery Tool:"
		And I choose "xDC Gurugram" from the radio button group for the question "Remote Delivery Team:"
		And I choose "xDC Gurugram" from the radio button group for the question "Local Delivery Location:"
	#<5>
		#definition page
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
	#</5>
		And I enter "10" into the textbox for the question "Number of Servers:"
		And I enter "5" into the textbox for the question "Estimated duration (weeks):"
		And I enter "1" into the textbox for the question "Additional Local Project Manager Effort (Days):"
		And I enter "1" into the textbox for the question "Additional Remote Project Manager Effort (Days):"
		And I enter "1" into the textbox for the question "Additional Local Delivery Effort (Days):"
		And I enter "1" into the textbox for the question "Additional Remote Delivery Effort (Days):"
		And I enter "5000" into the textbox for the question "Business Volume:"
	#<6>
		#scope page
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
	#</6>
	#<7>
		#customer pricing page
		And I click the button with the text "Next" identified by the parent class "heap-next-3"
	#</7>
		And I enter "ABCD" into the textbox for the question "Azure Tenant Info:"
		And I enter "ABCD" into the textbox for the question "Azure Subscription Info:"
	#<8>
		#questionnaire page
		And I click the button with the text "Next" identified by the parent class "heap-next-5"
	#</8>
		#And I Select Document Type as PDF
		And I choose "PDF" from the dropdown for the question "Document Type:"
	#<9>
	#contacts page
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
	#</9>
	Then I should see the value of contract