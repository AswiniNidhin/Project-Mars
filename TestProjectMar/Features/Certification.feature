Feature: Certification
	I have to navigate to the profile page to add profile details in certification tab


	Scenario: Entering valid data to certification tab
	Given I have navigated to profile to page
	Given I click on certification tab and addnew button
	Then I add certification detail data 
	| Certificate     | CertifiedFrom       |
	| Whitehate Award | WhiteHate community |
	

	
	# Textcases
	#Scenario:  Update data to certification tab
	#Scenario:  delete data from certification tab