Feature: CookiePolicy

as a user on ET Money website 
I want to view the cookie policy

@tag1
Scenario: Validate that user can view cookie policy on ET Money website
	Given user navigate to the website "https://loans.reteicons.com/"
	And i click ok to accept cookies
	When user click cookie policy
	Then the cookie policy page should displayed
