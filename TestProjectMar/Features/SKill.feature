Feature: Add skill Profile details
	I have to navigate to the profile page to add profile details in skills


@regression
Scenario: Entering valid data to skill tab
	Given I have navigated to profile page
	And I click on the skills tab 
	When I enter the skill text 
	#And I click skill add button
	Then I should see a popup saying skill addded

	#Testcases
	#Scenario:  Updating data From skill tab
	#Scenario: Deleting data from skill tab

	#Testcase for adding Profile  details
	#Scenario:I us a seller able add profile personal details
	#Scenario: I us a Seller able Update profile personal details
	#Scenario: I us a Seller able delete profile personal details
	
	#Scenario: I us a Seller able load the profile photo
	#Scenario: I us a Seller able delete profile photo

	
#Scenario: Entering valid date to language tab
#Scenario: Update data in language 
#Scenario: Delete data in language tab



