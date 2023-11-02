Feature: CPQUISecurityPostureAssessment

This Feature will test the UI Statbility for Security Posture Assessment Solution in CPQ UI and compare the expected output

@smoke
Scenario: Test Security Posture Assessment Solution UI Stability On CPQ UI for SPAE
	Given I Navigate to CPQ UI Page
	And I Enter following Login Details and Click Login Button
		| Username                            | Password				 |
		| helpdesk-scg.global@softwareone.com | CPQ.account1708 |
	And I click on New Contract Button
	And I configure client details for new Contract
	And I click on Service "Security Posture Assessment for AWS"
	#And I click on Configure Now Button for SPAE 'In PROD we do not have Configure Now Button 
	And I Entered Value for technical assessment for SPAE as "100"
	And I Choose Yes for serverless based workloads for SPAE
	And I click Next on Scope Page for SPAE
	And I Choose Days to Build My Plan for SPAE
	And I click Next Customer Pricing Page for SPAE
	#And I click Next Margin As Sold Page for SPAE
	And I fill Questionnaire Page questions for SPAE
	And I click Next on Questionaire Page for SPAE
	And I Select Document Type as PDF for APAE
	And I Add Authorized Contacts for SPAE
	And I add Softwareone Contacts for SPAE
	When I click Finish on Contacts Page for SPAE
	Then I should see the value of contract