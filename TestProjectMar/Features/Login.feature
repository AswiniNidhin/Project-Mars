Feature: Login
	I login to website
@mytag
Scenario: Login to website
	Given I have the website
	And I have navigated to login to page
	| username                  | password     |
	| aswini.sanal@outlook.com | Testing0123* |
	And I click login
	Then I able enter Profie page