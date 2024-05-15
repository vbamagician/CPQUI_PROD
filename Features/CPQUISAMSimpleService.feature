Feature: CPQUISAMSimpleService

This feature is dedicated to testing the UI Health of the SAMSimple Service within the CPQ UI. 
The primary objective is to ensure a consistent and seamless user experience while configuring a new 
contract for the SAMSimple Service.

  @smoke
  Scenario: Verify UI Health while Configuring SAMSimple Service in CPQ UI
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
		And I click the "Get Contract" button associated with the reference text "SAMSimple"
		And I click the button containing the text "Configure Now" Only If button found within 30 seconds else skip
#Definition Page
		And I choose "Yes" from the radio button group for the question "Please confirm, we are able to do so"
		And I choose the radio button option "We are able to deploy the SAMSimple inventory agents to all devices in scope" specifically
		And I click the button with the text "Next" identified by the parent class "heap-next-1"
#Scope Page
		And I click on the tile having text "ActivePDF"
		And I enter "1" into the textbox for the question "# End-user Device:" and press "Enter"
		And I enter "1" into the textbox for the question "# Servers (Physical & Virtual):" and press "Enter"
		And I enter "1" into the textbox for the question "# Users:" and press "Enter"
		And I click on the tile having text "Linux"
		And I enter "1" into the textbox for the question "# Trusted Domains:" and press "Enter"
		And I enter "1" into the textbox for the question "# Untrusted Domains:" and press "Enter"
		And I enter "1" into the textbox for the question "# Locations:" and press "Enter"
		And I enter "1" into the textbox for the question "# Segregated Networks:" and press "Enter"
		And I click on the tile having text "HP-UD (DDMI)"
		And I click on the tile having text "PDQ Deploy"
		And I click on the tile having text "Microsoft Hyper-V"
		And I click on the tile having text "Microsoft App-V"
		And I click on the tile having text "Microsoft Office 365"
		And I click the button with the text "Next" identified by the parent class "heap-next-2"
#Customer Pricing Page
		And I choose "Medium" from the radio button group for the question "Implementation Level: Based on the provided scoping information, the implementation may be Complex"
		And I click the button with the text "Next" identified by the parent class "heap-next-3"
#Questionnaire Page
		And I click the element contains the text "Add Domain"
		And I choose "Trusted" from the dropdown for the question "Is this a trusted or untrusted domain?"
		And I enter "ABCD" into the textbox for the question "Domain name:"
		And I click the element contains the text "Save & Add another"
		And I click to close the form "Add Domain"

		And I click the element contains the text "Add Domain"
		And I choose "Untrusted" from the dropdown for the question "Is this a trusted or untrusted domain?"
		And I enter "ABCD" into the textbox for the question "Domain name:"
		And I click the element contains the text "Save & Add another"
		And I click to close the form "Add Domain"
		
		And I click the element contains the text "Add Location"
		And I enter "India" into the textbox for the question "Geographic location:"
		And I click the element contains the text "Save & Add another"
		And I click to close the form "Add new location"
		
		And I click the element contains the text "Add Network"
		And I enter "ABCD" into the textbox for the question "Details:"
		And I click the element contains the text "Save & Add another"
		And I click to close the form "Add new segregated network"
		
		And I click the element contains the text "Add Application virtualization Details"
		And I enter "ABCD" into the textbox for the question "Product:"
		And I enter "1" into the textbox for the question "Version:"
		And I enter "2" into the textbox for the question "Edition:"
		And I click the element contains the text "Save & Add another"
		And I click to close the form "Add new record"
		
		And I click the element contains the text "Add Virtualization Platform Details"
		And I enter "ABCD" into the textbox for the question "Product:"
		And I enter "1" into the textbox for the question "Version:"
		And I enter "2" into the textbox for the question "Edition:"
		And I click the element contains the text "Save & Add another"
		And I click to close the form "Add new record"
		
		And I choose "Option A: Quarterly consumption subscription invoice" from the dropdown for the question "Invoicing frequency:"
		And I click the button with the text "Next" identified by the parent class "heap-next-5"
#Contacts Page 
		And I choose "PDF" from the dropdown for the question "Document Type:"
	When I click the button with the text "Finish" identified by the parent class "heap-finish"
	Then I should see the value of contract
