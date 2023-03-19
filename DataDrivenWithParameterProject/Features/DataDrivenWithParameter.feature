Feature: DataDrivenWithParameter

As a User In Order to
Benefit From the website
I will need to  first register

@tag1
Scenario: Data Driven With Parameter
		Given  I navigate to "https://angularjs.realworld.io/#/"
	And I enter Username "KQ007"
	And I enter Email "example1234@gmail.com"
	And I enter password "PasswordSec"
	When I click on the sign up botton
	Then I should be able to register successfully
