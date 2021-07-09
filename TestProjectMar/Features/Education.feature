Feature: Education
	I have to navigate to the profile page to add profile details in education tab


	Scenario: Entering valid data to education tab
	Given I have navigated to profile to page
	And I click on the education tab 
	When I enter the education/degree detail data 
	|University | degreeName |
	| Uni USQ | BioMed |


	#Testcases
	#Scenario: Updata education tab
	#Scenario:Delete data from education tab