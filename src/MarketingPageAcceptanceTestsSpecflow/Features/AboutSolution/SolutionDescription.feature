﻿Feature: Display Marketing Page Form - Solution Description Section
	As a Supplier
	I want to manage Marketing Page Information for the About Solution + Summary Description Section
	So that I can ensure the information is correct

Scenario: Sections presented
	Given that a Supplier has chosen to manage Marketing Page Information
	When the Marketing Page Form is presented
	Then there is a list of Marketing Page Form Sections 
	And the Supplier is able to manage the Solution Description Marketing Page Form Section

Scenario: Section status
	Given the Section has a content validation status
	When the Marketing Page Form is presented
	Then the Solution description content validation status is displayed