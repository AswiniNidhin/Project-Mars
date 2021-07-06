Feature: Login
	I login to website
@mytag
Scenario: Login to website
	Given I have the website
	And I enter email and password
	And I click login
	Then I able enter Profie page