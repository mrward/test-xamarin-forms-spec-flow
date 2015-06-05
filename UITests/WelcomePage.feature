Feature: WelcomePage
	Welcome page displayed when app is run.

Scenario: App is run
	Given App has started
	When I look at the screen
	Then the welcome screen show be displayed
