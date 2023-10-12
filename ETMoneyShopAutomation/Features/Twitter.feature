Feature: Twitter

A short summary of the feature

@tag1
Scenario: Validate user can view ET Money shop twitter page
	Given that a user navigate to the website "https://loans.reteicons.com/"
	And i click ok to accept cookies
	When user click twitter on the footer
	Then ET Money shop twitter page should displayed
