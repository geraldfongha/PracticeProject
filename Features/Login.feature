Feature: Login

As a user on MBA i want to login so that I can access my account

@smoke
Scenario: Login
	Given the user navigates to the website "https://employer.flexy.com/jobs/new/:jobId?/:step"
	When the user enters valid email "c.ezeh45@gmail.com"
	And the user enters valid password "nnenna123"
	And the user clicks the Let's go button
	Then the user is successfully logged in
	And user enters job title "tester"
	And user selects job category
	And user enters describtion "AutomationTester"
	And user selects working pattern
	And user enters dress code"smart"
	And user selects experience level
	And user enters name"Gerald"
	And user enters mobile number
	And user enters arrival instructions"CallGerald
	And user clicks next
	
