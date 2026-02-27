Feature: BookingTests

UI tests using Selenium that cover the booking of a hotel room as a user

Background:
	Given I am on the hotel booking page

Scenario: Book-Single-Room
	Given I have entered the check-in date as "2024-07-01" and the check-out date as "2024-07-05"
	And I select a single room
	When I reserve the room
	And I enter the details need to confirm the booking
	Then Then I should receive conformation of the booking
