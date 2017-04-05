Feature: Partner_Repository
	In order to trace Partner Data
	As an end-user
	I need to read a file with Partner Information
	And Return the partner Usage

@mytag
Scenario: Get ITunes
	Given I have a textfile with partners "d:\partners.txt"
	When the user enters partner 'ITunes' 
	Then the result should be "digital download"
	
Scenario: Get Digital Download
	Given I have a textfile with partners "d:\partners.txt"
	When the user enters partner usage 'digital download' 
	Then the partner should be "ITunes"
		