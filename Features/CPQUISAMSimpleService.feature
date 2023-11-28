Feature: CPQUISAMSimpleService

This feature will test the UI stability of SAM Simple Solution in CPQ

@smoke
Scenario: Test SAMSimple Solution UI Stability in CPQ UI PROD
	Given I Navigate to CPQ UI Page
	And I Enter following Login Details and Click Login Button
		| Username                            | Password        |
		| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "SAMSimple"
	And I click on Configure Now Button
	And I choose "Yes" to deploy the SAMSimple inventory agent on client Devices
	And I choose option of "We are able to deploy the SAMSimple inventory agents to all devices in scope"
	And I click on Next Button From Definition Page for SAMSimple
	And I select publisher as "ActivePDF"
	And I entered number of estimated end-user devices as "1"
	And I entered number of estimated physical and virtual servers as "1"
	And I entered number of estimated users as "1"
	And I select Operating System in use as "Linux"
	And I entered number of trusted domain as "1" for trusted domain
	And I entered number of untrusted domain as "1" for untrusted domain
	And I entered number of geographic location as "1"
	And I entered number of segregated networks as "1"
	And I select Inventory Inventory Data Source is deployed into the clients environment as "HP-UD (DDMI)"
	And I select an option as "PDQ Deploy" method of software distrubution
	And I select virtualization platform as "Microsoft Hyper-V"
	And I select application virtualization platform as "Microsoft App-V"
	And I select SaaS Platform as "Microsoft Office 365"
	And I click Next on Scope Page for SAMSimple
	And I select an option for implementation level as "Medium"
	And I click Next Customer Pricing Page for SAMSimple
	#And I click Next Margin As Sold Page for SAMSimple
	And I click on Add Domain Button to Add Trusted Domain
	And I select "Trusted" as option from Domain Form for Trusted Domain
	And I entered domain name as "ABCD" for Trusted Domain
	And I click on Save and Add Another button to add one more domain
	And I select "Untrusted" as option from Domain Form for Untrusted Domain
	And I entered domain name as "ABCD" for Untrusted Domain
	And I click on Save button to close domain form
	And I click on Add Location Button To Add Gegraphic Location
	And I entered geographic location as "India"
	And I click on Save button to close Location form
	And I click on Add Network button To Add Segregated Networks
	And I entered Segregated Network as "ABCD"
	And I click on Save button to close Segregated Networks Form
	And I click on Add Application virtualization Details button To Add Virtual Application Details
	And I entered product as "ABCD" for Application virtualization
	And I entered Version as "A01" for Application virtualization
	And I entered Edition as "ABCD" for Application virtualization
	And I click on Save button to close Application Virtualization form
	And I click on Add Virtualization Platform Details button To Add Virtualization Platform Details
	And I entered product as "ABCD" for Virtualization Platform
	And I entered Version as "A01" for Virtualization Platform
	And I entered Edition as "ABCD" for Virtualization Platform
	And I click on Save button to close Virtualization Platform form
	And I select Invoice Frequency option as "Option A: Quarterly consumption subscription invoice"
	And I click Next on Questionaire Page for SAMSimple
	And I Select Document Type as PDF
	And I Add Authorized Contacts
	And I add Softwareone Contacts
	When I click Finish on Contacts Page
	Then I should see the value of contract
