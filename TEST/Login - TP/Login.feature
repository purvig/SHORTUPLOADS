Feature: Login
	In order to login Shortuploads
	As a user
	I want to be able to login Shortuploads website

@login
Scenario: Verify Login
	Given I navigate to shortuploads
	When I click login
	And I enter login details
	Then I am signed in to shortuploads
