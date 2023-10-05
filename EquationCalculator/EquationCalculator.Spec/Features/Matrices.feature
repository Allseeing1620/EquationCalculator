Feature: Matrices

@mytag
Scenario: Sum two matrices
	Given the first matrix is 1,2,3|4,5,6|7,8,9
	And the second matrix is 9,8,7|6,5,4|3,2,1
	And the sign is +
	When the two matrices are added
	Then the result of equation should be 10,10,10|10,10,10|10,10,10
	
@mytag
Scenario: Diff two matrices
	Given the first matrix is 1,2,3|4,5,6|7,8,9
	And the second matrix is 1,0,0|2,0,0|3,0,0
	And the sign is -
	When the two matrices are added
	Then the result of equation should be 0,2,3|2,5,6|4,8,9