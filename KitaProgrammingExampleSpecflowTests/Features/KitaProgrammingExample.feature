Feature: KitaProgrammingExample
Scenario: New song is entered
	Given the user has entered a song
	When the song does not exist
	Then the output will tell the user and be added to the list

Scenario: Existing song is entered
	Given the user has entered a song
	When the song already exists
	Then the output will tell the user and not be added to the list