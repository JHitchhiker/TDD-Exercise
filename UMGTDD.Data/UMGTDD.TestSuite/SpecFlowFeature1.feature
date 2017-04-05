Feature: ITunes_Feature
	In order to trace Partner Data
	As an end-user
	I need to have a data model to store data in

@mytag
Scenario: Get ITunes
	Given I have a textfile "d:\partners.txt"
	When the user enters 'ITunes 1st March 2012' 
	Then the result should be "digital download"
	