Feature: AboutUs


As user on the ETMoney shop website 
I want to be able to view the about us page

@tag1
Scenario: Validate user view the about us
	Given that user navigate to the website "https://loans.reteicons.com/"
	When user click the about us on the header
	Then about us page is displayed
