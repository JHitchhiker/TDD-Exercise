Feature: ConsoleCommandHandler
	In order to track 
	As a user
	I want to be told the available songs within a time period

@mytag
Scenario: ITunes 1st March 2012
	Given I have entered 'ITunes 1st March 2012' into the console
	Then the resultcount should be 4
	And the first result should be "Monkey Claw|Black Mountain|digital download|1st Feb 2012|"
	And the second result should be "Monkey Claw|Motor Mouth|digital download|1st Mar 2011|"
	And the third result should be "Tinie Tempah|Frisky (Live from SoHo)|digital download|1st Feb 2012|"
	And the fourth result should be "Tinie Tempah|Miami 2 Ibiza|digital download|1st Feb 2012|"
