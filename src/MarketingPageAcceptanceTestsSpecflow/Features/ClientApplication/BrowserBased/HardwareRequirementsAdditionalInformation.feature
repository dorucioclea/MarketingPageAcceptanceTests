﻿Feature: Suppliers - Browser based Hardware and Additional Information
	Edit Browser Based Client Type - Hardware Requirements
		As a Supplier
		I want to edit the Hardware Section
		So that I can make sure the information is correct

	Edit Browser Based Client Type - Additional Information
		As a Supplier
		I want to edit the Additional Information Sub-Section
		So that I can make sure the information is correct

Scenario Outline: Does not exceed maximum
	Given the Supplier has entered <MaxChars> characters on the <PageTitle> page in the Browser based section
	When the Supplier attempts to save 
	Then the <PageTitle> is saved

	Examples: 
	| PageTitle              | MaxChars |
	| Hardware requirements  | 500      |
	| Additional information | 500      |

Scenario Outline: Does exceed maximum
	Given the Supplier has entered <MaxChars> characters on the <PageTitle> page in the Browser based section
	When the Supplier attempts to save 
	Then the Section is not saved 
	And an indication is given to the Supplier as to why

	Examples: 
	| PageTitle              | MaxChars |
	| Hardware requirements  | 501      |
	| Additional information | 501      |

Scenario Outline: Sub-Section marked as Incomplete - No Mandatory Data Required + no data
	Given the <PageTitle> Sub-Section in the Browser based section does not require Mandatory Data
	And a Supplier has not saved any data in any field within the Sub-Section
	When the Browser based Client Application Sub-Form is presented
	Then the <PageTitle> Sub-Section is marked as Incomplete 

	Examples: 
	| PageTitle              | 
	| Hardware requirements  | 
	| Additional information |

Scenario Outline: Sub-Section marked as Complete - No Mandatory Data Required + data present
	Given the <PageTitle> Sub-Section in the Browser based section does not require Mandatory Data
	And a Supplier has saved any data in any field within <PageTitle>
	When the Browser based Client Application Sub-Form is presented
	Then the <PageTitle> Sub-Section is marked as Complete

	Examples: 
	| PageTitle              |
	| Hardware requirements  |
	| Additional information |