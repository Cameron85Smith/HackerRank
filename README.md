# HackerRank

### Exercise 1: Solve Me First
Complete the function solveMeFirst to calculate the sum of two integers.

Return
int: The sum of two integers.

Sample Input
a = 2
b = 3

Sample Output
5

### Exercise 2: Simple Array Sum
Given a list of integers, find the sum of its elements.
For example, if the list ar = [1, 2, 3], 1 + 2 + 3 = 6 , so return 6.

Return
int: The sum of all the elements in the list.

Input Format
The line contains n space-separated integers that describe arr[n].

Sample Input
1 2 3 4 10 11

Sample Output
31

### Exercise 3: Compare The Triplets
Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.
The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).
The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].
If a[i] > b[i], then Alice is awarded 1 point.
If a[i] < b[i], then Bob is awarded 1 point.
If a[i] = b[i], then neither person receives a point.
Comparison points is the total points a person earned.
Given a and b, determine their respective comparison points.

Return
int[2]: Alice's score is in the first position, and Bob's score is in the second.

Input Format
The first and second line contains n space-separated integers that describe arr[n].

Sample Input
5 6 7
3 6 10

Sample Output
1 1

### Exercise 4: A Very Big Sum
Calculate and print the sum of the elements in the list, keeping in mind that some of those integers may be quite large.

Return
long: The sum of all the elements in the list.

Input Format
The line contains n space-separated integers that describe arr[n].

Sample Input
1000000001 1000000002 1000000003 1000000004 1000000005

Sample Output
5000000015

### Exercise 5: Diagonal Difference
Calculate the diagonal difference of a matrix.

The square matrix arr is shown below:
1 2 3
4 5 6
9 8 9

The left-to-right diagonal = 1 + 5 + 9 = 15.
The right to left diagonal = 3 + 5 + 9 = 17.
Their absolute difference is |15 - 17| = 2.

Return
int: the absolute diagonal difference

Input Format
The first line contains an integer, n, the size of the list. 
The second, third, and fourth line contains n space-separated integers that describe arr[n].

Sample Input
3
11 2 4
4 5 6
10 8 -12

Sample Output
15

### Exercise 6: Plus Minus
Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with places after the decimal. Note: This challenge introduces precision problems. The output should be scaled to six decimal places, though answers with absolute error of up to 10^-4 are acceptable.

Example 
arr = [1, 1, 0, -1, -1]

Example 
There are n = 5 elements, two positive, two negative and one zero.
Their ratios are 2/5 = 0.400000, 2/5 = 0.400000 and 1/5 = 0.200000.

Results are printed as:
0.400000
0.400000
0.200000

Input Format
The first line contains an integer, n, the size of the list. 
The second line contains n space-separated integers that describe arr[n].

Sample Input
6
-4 3 -9 0 4 1

Sample Output
0.500000
0.333333
0.166667

### Exercise 7: Staircase
This is a staircase of size n = 4:
 ```
   #
  ##
 ###
####
```
Its base and height are both equal to n. It is drawn using # symbols and spaces. The last line is not preceded by any spaces.
Write a program that prints a staircase of size n.

Input Format
A single integer, n, denoting the size of the staircase.

Sample Input
6

Sample Output
```
     #
    ##
   ###
  ####
 #####
######
```

Explanation
The staircase is right-aligned, composed of # symbols and spaces, and has a height and width of n = 6.

### Exercise 8:
Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

Example
arr = [1, 3, 5, 7 ,9]

The minimum sum is 1 + 3 + 5 + 7 = 16 and the maximum sum is 3 + 5 + 7 + 9 = 24.
The function prints:
16 24

Input Format
A single line of five space-separated integers.

Sample Input
1 2 3 4 5

Sample Output
10 14

### Exercise 9
You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

Example
candles = [4, 4, 1, 3]

The maximum height candles are 4 units high. There are 2 of them, so return 2.

Input Format
The first line contains a single integer, n, the size of candles[]. 
The second line contains n space-separated integers, where each integer i describes the height of candles[i].

Sample Input
4
3 2 1 3

Sample Output
2

Explanation
Candle heights are [3, 2, 1, 3]. The tallest candles are 3 units, and there are 2 of them.

### Exercise 10
Given a time in -hour AM/PM format, convert it to military (24-hour) time.

Returns
string: the time in 24 hour format

Input Format
A single string s that represents a time in 12-hour clock format (i.e.: hh:mm:ssAM or hh:mm:ssPM).

Sample Input
07:05:45PM

Sample Output
19:05:45

### Exercise 11
HackerLand University has the following grading policy:
Every student receives a grade in the inclusive range from 0 to 100.
Any grade less than 40 is a failing grade.
Sam is a professor at the university and likes to round each student's grade according to these rules:
If the difference between the grade and the next multiple of 5 is less than 3, round  up to the next multiple of 5.
If the value of grades is less than 38, no rounding occurs as the result will still be a failing grade.

Examples
grade = 84 round to  (85 - 84 is less than 3)
grade = 29 do not round (result is less than 40)
grade = 57 do not round (60 - 57 is 3 or higher)

Given the initial value of n for each of Sam's students, write code to automate the rounding process.

Returns
int[n]: the grades after rounding as appropriate.

Input Format
The first line contains a single integer, n, the number of students. 
Each line i of the n subsequent lines contains a single integer, grades[i].

Sample Input
4
73
67
38
33

Sample Output
75
67
40
33

### Exercise 12
Sam's house has an apple tree and an orange tree that yield an abundance of fruit. Using the information given below, determine the number of apples and oranges that land on Sam's house.

The house has a starting point of s, and an endpoint of t.
The apple tree is to the left of the house, and the orange tree is to its right.
Assume the trees are located on a single point, where the apple tree is at point a, and the orange tree is at point b.
When a fruit falls from its tree, it lands d units of distance from its tree of origin along the x-axis. *A negative value of  means the fruit fell d units to the tree's left, and a positive value of d means it falls d units to the tree's right.

Given the value of d for m apples and n oranges, determine how many apples and oranges will fall on Sam's house (i.e., in the inclusive range [s, t])?

For example, Sam's house is between s = 7 and t = 10. The apple tree is located at a = 4 and the orange at b = 12. There are m = 3 apples and n = 3 oranges. Apples are thrown apples = [2, 3, -4] units distance from a, and oranges = [3, -2, -4] units distance. Adding each apple distance to the position of the tree, they land at [4 + 2, 4 + 3, 4 + -4] = [6, 7, 0]. Oranges land at [12 + 3, 12 + -2, 12 + -4] = [15, 10, 8]. One apple and two oranges land in the inclusive range 7 - 10 so we print:
```
1
2
```

Input Format
The first line contains two space-separated integers denoting the respective values of s and t.
The second line contains two space-separated integers denoting the respective values of a and b.
The third line contains two space-separated integers denoting the respective values of m and n.
The fourth line contains m space-separated integers denoting the respective distances that each apple falls from point a.
The fifth line contains n space-separated integers denoting the respective distances that each orange falls from point b.

Output Format
Print two integers on two different lines:
The first integer: the number of apples that fall on Sam's house.
The second integer: the number of oranges that fall on Sam's house.

Sample Input
7 11
5 15
3 2
-2 2 1
5 -6

Sample Output
1
1

Explanation
The first apple falls at position 5 - 2 = 3.
The second apple falls at position 5 + 2 = 7.
The third apple falls at position 5 + 1 = 6.
The first orange falls at position 15 + 5 = 20.
The second orange falls at position 15 - 6 = 9.
Only one fruit (the second apple) falls within the region between 7 and 11, so we print 1 as our first line of output.
Only the second orange falls within the region between 7 and 11, so we print 1 as our second line of output.

### Exercise 13:
You are choreographing a circus show with various animals. For one act, you are given two kangaroos on a number line ready to jump in the positive direction (i.e, toward positive infinity).
The first kangaroo starts at location x1 and moves at a rate of v1 meters per jump.
The second kangaroo starts at location x2 and moves at a rate of v2 meters per jump.
You have to figure out a way to get both kangaroos at the same location at the same time as part of the show. If it is possible, return "YES", otherwise return "NO".

Example
x1 = 2
v1 = 1
x2 = 1
v2 = 2

After one jump, they are both at x = 3, (x1 + v1 = 2 + 1, x2 + v2 = 1 + 2), so the answer is "YES".

Returns
string: either YES or NO

Input Format
A single line of four space-separated integers denoting the respective values of x1, v1, x2, and v2.

Sample Input
0 3 4 2

Sample Output
YES