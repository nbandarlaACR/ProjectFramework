Feature: Login
	Verify valid and invalid login scenarios

@SmokeTest @US1309 @TC1231
@test-loginTest
Scenario: Verify user can see login page    
	Given User is in welcome page of the application
	| WelcomeUserMessage |
	| Welcome, Guest |
	When User clicks login link
	Then User should see okta signin button
	| SignInMessage |
	| Sign In       |