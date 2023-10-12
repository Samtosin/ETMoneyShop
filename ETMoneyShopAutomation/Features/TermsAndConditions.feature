Feature: TermsAndConditions

A short summary of the feature

@tag1
Scenario: Validate that user can view the Terms and Condition page
	Given that i navigate to the ET money website "https://loans.reteicons.com/"
	And i click ok to accept cookies
	When i click on Terms and Conditions on the footer
	Then the Terms and Conditions page should displayed