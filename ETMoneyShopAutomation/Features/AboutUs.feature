Feature: AboutUs


A short summary of the feature

@tag1
Scenario: Validate user view the about us
	Given that user navigate to the website "https://loans.reteicons.com/"
	When user click the about us on the header
	Then about us page is displayed
