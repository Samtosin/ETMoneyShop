Feature: Instagram

A short summary of the feature

@tag1
Scenario: Validate user can view ET Money shop instagram page
	Given that a user navigate to the website "https://loans.reteicons.com/"
	And i click ok to accept cookies
	When user click instagram on the footer
	Then ET Money shop instagram page should displayed
