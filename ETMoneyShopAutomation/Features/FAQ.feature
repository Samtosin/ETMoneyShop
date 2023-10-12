Feature: FAQ

As a user i want to click on FAQ

@tag1
Scenario: [Verify user can click on FAQ]
	Given am a user on the website "https://loans.reteicons.com"
	When I click on FAQ on the header
	Then FAQ search bar should popup
