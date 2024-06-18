Feature: CPQUICMDBHealthCheck

This feature focuses on testing the UI Health of the CMDB Health Check solution within 
the CPQ environment. The primary objective is to ensure a reliable and smooth user interface 
experience while configuring a new contract for CMDB Health Check solution.

  @smoke
  Scenario: Verify UI Health while Configuring CMDB Health Check solution in CPQ
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
		And I click the "Get Contract" button associated with the reference text "CMDB Health Check"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
#Definition Page 
		#And I click the button containing the text "Add Milestone"
		#And I enter "CMDB Health Check Milestone 2" into the textbox for the question "Name:"
		#And I choose "Recurring" from the radio button group for the question "Payment frequency:"
		#And I enter "ABCD" into the textarea for the question "Success Criteria:"
		#And I enter "ABCD" into the textarea for the question "Risks:" 
		#And I click the button containing the text "Confirm"
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
#Scoping Page
		#Add New Milestone
		#And I click the button containing the text "Add New Task"
		#And I enter "CMDB Health Check Task ABCD" into the textbox for the question "Title:"
		#And I enter "30" into the textbox for the question "Effort in Hours:"
		#And I choose "CMDB Health Check Milestone 2" from the dropdown for the question "Milestone:"
		#And I click the button containing the text "Confirm"
		#Add New Expense
		#And I click the button containing the text "Add New Expense"
		#And I choose "Customer Visable" from the radio button group for the question "Margin reducing or Customer Visible"
		#And I choose "Hotel" from the dropdown for the question "Type:"
		#And I enter "ABCD" into the textbox for the question "Name:"
		#And I enter "ABCDABCDABCDABCDABCDABCDABCDABCDABCDABCD" into the textarea for the question "Description:"
		#And I enter "1000" into the textbox for the question "Cost:"
		#And I enter "20" into the textbox for the question "Markup %:"
		#And I choose "CMDB Health Check Milestone 2" from the dropdown for the question "Milestone:"
		#And I click the button containing the text "Save"
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
#Customer Pricing
	When I click the button with the text "Next" identified by the parent class "heap-next-3"
#Questionnaire Page
	#When I click the button with the text "Finish" identified by the parent class "heap-finish"
#Opportunity Page 
	Then I should see the value of contract