﻿Feature: Quadratic

@mytag
Scenario: Solve quadratic
	Given the a is 1
	And the b is 4
	And the c is -5
	When Quadratic equation are solved
	Then the x should be x = 1; -5
	
@mytag
Scenario: Calc discriminant
	Given the a is 1
	And the b is 4
	And the c is -5
	When Discriminant are solved
	Then the D should be 36
	