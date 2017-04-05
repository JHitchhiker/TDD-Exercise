Feature: ArtistRepository
	In order to find Music Artists
	As a user
	I need to read a file and return the artist information found

@mytag
Scenario: Get Artist By Song
	Given I have a textfile with artists "d:\musicartists.txt"
	When I enter song "Motor Mouth"
	Then the artist should be "Monkey Claw"

Scenario: Get Artist By Usage
	Given I have a textfile with artists "d:\musicartists.txt"
	When I enter usage "digital download"
	Then the artist count should be 6