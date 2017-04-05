Feature: Youtube
	In order to track artists
	As a user
	I want to be told the available songs within a time period for Youtube

@mytag
Scenario: YouTube 1st April 2012
	Given 'YouTube 1st April 2012' was entered into the console
	Then the youtube_resultcount should be 2
	And the youtube_firstresult should be "Monkey Claw|Motor Mouth|streaming|1st Mar 2011|"
	And the youtube_secondresult should be "Tinie Tempah|Frisky (Live from SoHo)|streaming|1st Feb 2012|"

Scenario: YouTube 27th Dec 2012
	Given 'YouTube 27th Dec 2012' was entered into the console
	Then the December_resultcount should be 4
	And the firstdecemeberresult should be "Monkey Claw|Christmas Special|streaming|25th Dec 2012|31st Dec 2012"
	And the seconddecemeberresult should be "Monkey Claw|Iron Horse|streaming|1st Jun 2012|"
	And the thirddecemeberresult should be "Monkey Claw|Motor Mouth|streaming|1st Mar 2011|"
	And the fourthdecemeberresult should be "Tinie Tempah|Frisky (Live from SoHo)|streaming|1st Feb 2012|"