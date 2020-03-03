Feature: Login
	In order to use the Ieso Therapy site
	As an existing user
	I want to be able to Login and Logout

Background: User is on the Registration
	Given I am on the Login page

Scenario: Login as an existing user with correct login details
    When I enter correct details and login
	| email                                     | password |
	| ieso.digital+joyprivacypatient4@gmail.com | Logarp44 |

	Then I should be navigated to the user account page
	
Scenario Outline: Login with incorrect login details
	When I enter incorrect login details "<email>" "<password>"
	Then I should see an error "<message>" displayed on the page

	Examples: 
	| email                                 | password | message                 |
	| mkjufhfhuwhkmfwhh.gmail.com           |          | Wrong email or password |
	| ieso.digital+test2cassini@gmail.com   |Logarp44  | Wrong email or password |

Scenario: Logout as an existing user
	When I successfully login with my details 
	Then I should be able to logout

Scenario: View my profile as an existing user
	When I successfully login with my details 
	Then I should be able to view my profile