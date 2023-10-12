Feature: ContactUs

A short summary of the feature

@tag1
Scenario: Validate that a user can contact us
	Given that i navigate to the website "https://loans.reteicons.com/"
	When i click contact us on the header
	Then contact us page should displayed
	#And i enter email
	#And i enter firstname "Samson"
	#And i enter lastname "Gbenga"
	#And enter message "I want to pawn my TV"
	#And i click submit
	#Then i should be able to contant ETmoney Shop