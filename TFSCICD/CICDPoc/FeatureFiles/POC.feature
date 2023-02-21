Feature: POC
	In order to ensure app installation is done in site
	As a Deca tester
	I want to ensure Decafying App is installed


@mytag
Scenario: Verify Google is launched
	Given I have launched test site 
	When I Search For Apple
	Then  Apple Test Result Is displayed
