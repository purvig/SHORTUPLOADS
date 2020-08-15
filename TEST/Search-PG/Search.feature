Feature: Search
	In order to search videos in shortuploads
	As a user
	I want to be able to search videos

@search
Scenario: search for videos
	Given I navigate to shortuploads website
	When I search for Lift
	Then I see the page loads with search results