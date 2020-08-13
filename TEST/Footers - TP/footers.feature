Feature: footers
	In order to view footers
	As a user
	I want to be able to click on those

@footers
Scenario Outline: Verify Footers
	Given I navigate to shortuploads
	When I click on <footers>
	Then I see the <footers> page
	Examples:
	|footers|
	|About Us|
	|Privacy Policy|
	|Terms Of Use|
	|Contact Us|