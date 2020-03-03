Feature: RegisterUser
	In order to use the Ieso Therapy site
	As a new user
	I want to be able to Sign up

Background: User is on the Registration
	Given I am on the Registration page
	
Scenario: Register with correct email and password format
	When I enter correct email format and password 'Logarp44' and signup
	Then I should be navigated to the Welcome page
	
Scenario: Register with correct email and password format without accepting privacy policy
	When I enter correct email format and password "Logarp44" without accepting privacy policy
	Then I should see "You must agree to the terms and conditions" displayed on the page
	
Scenario: Register with an existing user details
	When I enter existing user details "ieso.digital+joyprivacypatient@gmail.com" "Logarp44" and signup
	Then I should see the message "Invalid sign up" displayed on the page
		
Scenario Outline: Register with incorrect email and password format
	When I enter incorrect "<email>" and incorrect "<password>" and signup
	Then I should see error "<message>" displayed on the page

	Examples: 
	| email                                 | password | message                 |
	| ffhfhuwhfwhfwh.gmail.com              |          | (password) is too short |
	|                                       |          | (password) is too short |
	|                                       | Logarp44 | error in email          |
	| ieso.digital+joytestcassini@gmail.com |          | (password) is too short |
	| ieso.digital+joytestcassini@gmail.com | f123     | object                  |
	| ebfnsbfabjsfbasjf.com@gmail           | dghn     | error in email          |


