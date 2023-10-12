Feature: Blog

A short summary of the feature

@tag1
Scenario: Validate that user can view Blog Page
	Given that I navigate to the ET money website "https://loans.reteicons.com/"
	When I click on blog on the header
	Then blog page should be displayed
