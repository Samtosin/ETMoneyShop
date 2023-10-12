Feature: LegalInformation

A short summary of the feature

@tag1
Scenario: Validate that user can view legal information page
	Given that i navigate to the ET money website "https://loans.reteicons.com/"
	And i click ok to accept cookies
	When i click legal information
	Then legal information page should displayed
