# ConsoleApp2

#Almost Anagram#
Two words make an Almost Anagram Pair if you can transform one into the other by switching out one letter and rearranging the letters if needed.

Examples of Almost Anagram Pairs:
- dark, card
- plate, table
- lead, read

Examples of non-Almost Anagrams Pairs:
- care, free (2 different letters)
- stop, pots (no different letters)
- ply, play (different lengths)

Write a program that takes in the
i) number of words (N)
ii) list of N words
and outputs the same list where next to each word we have the number of Almost Anagram Pairs it can form with the other words in the list.

The first line of the input is the number of words (N) and the following N lines are the words in that list.

The number of words in the list range from 5 to 50000. You can assume that all the words are unique, lowercase and at least 2 letters long.

Sample Input:

10
race
beat
brass
grass
sabre
back
chat
cabs
saga
pack

Output:
race 0
beat 0
brass 2
grass 1
sabre 1
back 2
chat 0
cabs 1
saga 0
pack 1

#Find Rotation#

3#  W3resource Basic Algorithm Part-I
https://www.w3resource.com/csharp-exercises/basic-algo/index.php#h_one
1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.
Sample Input:
1, 2
3, 2
2, 2
Expected Output:
3
5
12   

2. Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.
Sample Input:
53
30
51
Expected Output:
6
21
0

3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
Sample Input:
30, 0
25, 5
20, 30
20, 25
Expected Output:
True
True
True
False

4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
Sample Input:
103
90
89
Expected Output:
True
True
False

5. Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged.
Sample Input:
"if else"
"else"
Expected Output:
if else
if else

##### 08 December 2023 ##########

6. Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.
Sample Input:
"Python", 1
"Python", o
"Python", 4
Expected Output:
Pthon
ython
Pythn

7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
Sample Input:
"abcd"
"a"
"xy"
Expected Output:

dbca
a
yx

[7-8] [SELINGAN] ReverseString


8. Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string. 
     If the given string length is less than 2 return the original string.
Sample Input:
"C Sharp"
"JS"
"a"
Expected Output:
C C C C 
JSJSJSJS
a

9. Write a C# Sharp program to create a string with the last char added at the front and back of a given string of length 1 or more.
Sample Input:
"Red"
"Green"
"1"
Expected Output:
dRedd
nGreenn
111

10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.
Sample Input:
3
14
12
37
Expected Output:
True
True
True
False

11. Write a C# Sharp program to create a string taking the first 3 characters of a given string. Return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there.
Sample Input:
"Python"
"JS"
"Code"
Expected Output:
PytPythonPyt
JSJSJS
CodCodeCod
 
 ##### 09 December 2023 ########## 

12. Write a C# Sharp program to check if a given string starts with 'C#' or not.
Sample Input:
"C# Sharp"
"C#"
"C++"
Expected Output:
True
True
False

13. Write a C# Sharp program that checks whether one temperature is less than 0 and another is greater than 100.
Sample Input:
120, -1
-1, 120
2, 120
Expected Output:
True
True
False

14. Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
Sample Input:
100, 199
250, 300
105, 190
Expected Output:
True
False
True

 15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false.
Sample Input:
11, 20, 12
30, 30, 17
25, 35, 50
15, 12, 8
Expected Output:
True
True
True
False
 
16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the range, otherwise false.
Sample Input:
20, 84
14, 50
11, 45
25, 40
Expected Output:
True
True
True
False

17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string.

Sample Input:
"Python"
"ytade"
"jsues"
Expected Output:
Phon
ytade
jsues

18. Write a C# Sharp program to check the largest number among three given integers.

Sample Input:
1,2,3
1,3,2
1,1,1
1,2,2
Expected Output:
3
3
1
2

19. Write a C# Sharp program to check which number is closest to 100 among two given integers. Return 0 if the two numbers are equal.

Sample Input:
78, 95
95, 95
99, 70
Expected Output:
95
0
99

20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.

Sample Input:
78, 95
25, 35
40, 50
55, 60
Expected Output:
False
False
True
True

21. Write a C# Sharp program to find the largest value from two positive integer values in the range 20..30 inclusive. Return 0 if neither is in that range.

Sample Input:
78, 95
20, 30
21, 25
28, 28
Expected Output:
0
30
25
28

22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.

Sample Input:
"frizz"
"zane"
"Zazz"
"false"
"zzzz"
"ZZZZ"
Expected Output:
True
False
True
False
True
False

23. Write a C# Sharp program to check if two given non-negative integers have the same last digit.

Sample Input:
123, 456
12, 512
7, 87
12, 45
Expected Output:
False
True
True
False

24. Write a C# Sharp program to convert the last 3 characters of a given string to uppercase. If the length of the string is less than 3, then uppercase all the characters.

Sample Input:
"Python"
"Javascript"
"js"
"PHP"
Expected Output:
PytHON
JavascrIPT
JS
PHP

25. Write a C# Sharp program to create a string which is n (non-negative integer) copies of a given string.

Sample Input:
"JS", 2
"JS", 3
"JS", 1
Expected Output:
JSJS
JSJSJS
JS

26. Write a C# Sharp program to create a string that is n (non-negative integer) copies of the first 3 characters of a given string. If the given string is shorter than 3, return n copies of the string.

Sample Input:
"Python", 2
"Python", 3
"JS", 3
Expected Output:
PytPyt
PytPytPyt
JSJSJS

27. Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa".

Sample Input:
"bbaaccaag"
"jjkiaaasew"
"JSaaakoiaa"
Expected Output:
2
2
3

28. Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a".

Sample Input:
"caabb"
"babaaba"
"aaaaa"
Expected Output:
True
False
True

29. Write a C# Sharp program to create a string made of every other character starting with the first in a given string.

Sample Input:
"Python"
"PHP"
"JS"
Expected Output:
Pto
PP
J

30. Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd".

Sample Input:
"abcd"
"abc"
"a"
Expected Output:
aababcabcd
aababc
a 

31. Write a C# Sharp program to count a substring of length 2 that appears in a given string. This substring appears as the last 2 characters of the string. Do not count the end substring.

Sample Input:
"abcdsab"
"abcdabab"
"abcabdabab"
"abcabd"
Expected Output:
1
2
3
0

32. Write a C# Sharp program to check if a specified number is present in a given array of integers.

Sample Input:
{1,2,9,3}, 3
{1,2,2,3}, 2
{1,2,2,3}, 9
Expected Output:
True
True
False

33. Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.

Sample Input:
{1,2,9,3}, 3
{1,2,3,4,5,6}, 2
{1,2,2,3}, 9
Expected Output:
True
True
False

34. Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.

Sample Input:
{1,1,2,3,1}
{1,1,2,4,1}
{1,1,2,1,2,3}
Expected Output:
True
False
True

35. Write a C# Sharp program to compare two given strings and return the number of positions where they contain the same length of 2 substrings.

Sample Input:
"abcdefgh", "abijsklm"
"abcde", "osuefrcd"
"pqrstuvwx", "pqkdiewx"
Expected Output:
1
1
2

 ##### 10 December 2023 ##########

36. Write a C# Sharp program to create a string from a given string where a specified character is removed except for the beginning and ending positions.

Sample Input:
"xxHxix", "x"
"abxdddca", "a"
"xabjbhtrb", "b"
Expected Output:
xHix
abxdddca
xajhtrb

37. Write a C# Sharp program to create a string of characters at indexes 0,1, 4,5, 8,9 ... from a given string.

Sample Input:
"Python"
"JavaScript"
"HTML"
Expected Output:
Pyon
JaScpt
HT
38. Write a C# Sharp program to count the number of two 5's next to each other in an array of integers. Count the situation where the second 5 is actually a 6.

Sample Input:
{ 5, 5, 2 }
{ 5, 5, 2, 5, 5 }
{ 5, 6, 2, 9}
Expected Output:
1
2
1

39. Write a C# Sharp program to check if a triple is present in an array of integers or not. If a value appears three times in a row in an array it is called a triple.

Sample Input:
{ 1, 1, 2, 2, 1 }
{ 1, 1, 2, 1, 2, 3 }
{ 1, 1, 1, 2, 2, 2, 1 }
Expected Output:
False
False
True

40. Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30.

Sample Input:
12, 17
2, 17
22, 17
20, 0
Expected Output:
29
30
39
30

41. Write a C# Sharp program that accepts two integers and returns true if either is 5 or their sum or difference is 5.

Sample Input:
5, 4
4, 3
1, 4
Expected Output:
True
False
True

42. Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or one more than a multiple of 13.

Sample Input:
13
14
27
41
Expected Output:
True
True
True
False
43. Write a C# Sharp program to check if a given number that is not negative is a multiple of 3 or 7, but not both.

Sample Input:
3
7
21
Expected Output:
True
True
False

44. Write a C# Sharp program to check if a given number is within 2 of a multiple of 10.

Sample Input:
3
7
8
21
Expected Output:
False
False
True
True

45. Write a C# Sharp program to compute the sum of the two given integers. Return 18 if one of the given integer values is in the range of 10..20 inclusive.

Sample Input:
3, 7
10, 11
10, 20
21, 220
Expected Output:
100
18
18
241

46. Write a C# Sharp program to check whether a given string begins with "F" or ends with "B". 
       If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" If the string starts with "F" and ends with "B" return "FizzBuzz". In other cases return the original string.
In other cases return the original string.
Sample Input:
"FizzBuzz"
"Fizz"
"Buzz"
"Founder"
Expected Output:
Fizz
Fizz
Buzz
Fizz

47. Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers.

Sample Input:
1, 2, 3
4, 5, 6
-1, 1, 0
Expected Output:
True
False
True

48. Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.

Sample Input:
1, 2, 3
4, 5, 6
-1, 1, 0
Expected Output:
True
True
False

49. Write a C# Sharp program to check if three given numbers are in strict increasing order.
For example, 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8. However, if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7.

Sample Input:
1, 2, 3, false
1, 2, 3, true
10, 2, 30, false
10, 10, 30, true
Expected Output:
True
True
False
True

50. Write a C# Sharp program to check if two or more integers that are not negative have the same rightmost digit.

Sample Input:
11, 21, 31
11, 22, 31
11, 22, 33
Expected Output:
True
True
False

51. Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others.

Sample Input:
11, 21, 31
11, 22, 31
10, 20, 15
Expected Output:
True
True
False

52. Write a C# Sharp program to find the largest of two given integers. However if the two integers have the same remainder when divided by 7, then return the smallest integer. If the two integers are the same, return 0.

Sample Input:
11, 21
11, 20
10, 10
Expected Output:
21
20
0

53. Write a C# Sharp program to check two given integers, each in the range 10..99. Return true if a digit appears in both numbers, such as the 3 in 13 and 33.

Sample Input:
11, 21
11, 20
10, 10
Expected Output:
True
False
True

54. Write a C# Sharp program to compute the sum of two given non-negative integers x and y as long as the sum has the same number of digits as x. If the sum has more digits than x return x without y.

Sample Input:
4, 5
7, 4
10, 10
Expected Output:
9
7
20

55. Write a C# Sharp program to compute the sum of three given integers. Return the third value if the two values are the same.

Sample Input:
4, 5, 7
7, 4, 12
10, 10, 12
12, 12, 18
Expected Output:
16
23
12
18

56. Write a C# Sharp program to compute the sum of the three integers. If one of the values is 13 then do not count it and its right towards the sum.

Sample Input:
4, 5, 7
7, 4, 12
10, 13, 12
13, 12, 18
Expected Output:
16
23
10
0

 ##### 14 December 2023 ##########

57. Write a C# Sharp program to compute the sum of the three given integers. All values in the range 10..20 inclusive count as 0, except 13 and 17.

Sample Input:
4, 5, 7
7, 4, 12
10, 13, 12
14, 15, 16
Expected Output:
16
11
13
0

58. Write a C# Sharp program to check two integers and return the value nearest to 13 without crossing over. Return 0 if both numbers exceed.

Sample Input:
4, 5
7, 12
10, 13
17, 33
Expected Output:
5
12
13
0

 ##### 18 December 2023 ##########

59. Write a C# Sharp program to compare three integers (small, medium, and large) and return true if the difference between small and medium and the difference between medium and large is the same.

Sample Input:
4, 5, 6
7, 12, 13
-1, 0, 1
Expected Output:
True
False
True

60. Write a C# Sharp program to create a string using the two given strings s1, s2. The new string format will be s1s2s2s1.

Sample Input:
"Hi", "Hello"
"whats", "app"
Expected Output:
HiHelloHelloHi
whatsappappwhats

61. Write a C# Sharp program to insert a given string into the middle of another given string of length 4.

Sample Input:
"[[]]","Hello"
"(())", "Hi"
Expected Output:
[[Hello]]
((Hi))

62. Write a C# Sharp program to create a string using three copies of the last two characters of a given string of length at least two.

Sample Input:
"Hello"
"Hi"
Expected Output:
lololo
HiHiHi

63. Write a C# Sharp program to create a new string using the first two characters of a given string. If the string length is less than 2, return the original string.

Sample Input:
"Hello"
"Hi"
"H"
" "
Expected Output:
He
Hi
H

64. Write a C# Sharp program to create a string from the first half of a given string of even length.

Sample Input:
"Hello"
"Hi"
Expected Output:
He
H

65. Write a C# Sharp program to create a new string without the first and last character of a given string of length at least two.

Sample Input:
"Hello"
"Hi"
"Python"
Expected Output:
ell

ytho

66. Write a C# Sharp program to create a new string from two given strings, one of which is shorter and one of which is longer. The new string format will be long string + short string + long string.

Sample Input:
"Hello", "Hi"
"JS", "Python"
Expected Output:
HelloHiHello
PythonJSPython

67. Write a C# Sharp program to combine two strings of length at least 1, after removing their first character.

Sample Input:
"Hello", "Hi"
"JS", "Python"
Expected Output:
elloi
Sython

68. Write a C# Sharp program to move the first two characters to the end of a given string of length at least two.

Sample Input:
"Hello"
"JS"
Expected Output:
lloHe
JS

69. Write a C# Sharp program to move the last two characters to the start of a given string of length at least two.

Sample Input:
"Hello"
"JS"
Expected Output:
loHel
JS

70. Write a C# Sharp program to create a new string without the first and last characters of a given string of any length.

Sample Input:
"Hello"
"JS"
""
Expected Output:
ell

71. Write a C# Sharp program to create a string using the two middle characters of a given string of even length (at least 2).

Sample Input:
"Hell"
"JS"
Expected Output:
el
JS

72. Write a C# Sharp program to check if a given string ends with "on".

Sample Input:
"Hello"
"Python"
"on"
"o"
Expected Output:
False
True
True
False

73. Write a C# Sharp program to create a new string using the first and last n characters from a given string of length at least n.

Sample Input:
"Hello", 1
"Python", 2
"on", 1
"o", 1
Expected Output:
Ho
Pyon
on
oo

74. Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string.

Sample Input:
"Hello", 1
"Python", 2
"on", 1
Expected Output:
el
th
on

75. Write a C# Sharp program to create a string by taking at least 3 characters from the middle of a given string.

Sample Input:
"Hello"
"Python"
"abc"
Expected Output:
ell
yth
abc

76. Write a C# Sharp program to create a new string of length 2, using the first two characters of a given string. If the given string length is less than 2 use '#' as missing characters.

Sample Input:
"Hello"
"Python"
"a"
""
Expected Output:
He
Py
a#
##

77. Write a C# Sharp program to create a string by taking the first character from a string and the last character from another string. If a string's length is 0, use '#' as its missing character.

Sample Input:
"Hello", "Hi"
"Python", "PHP"
"JS", "JS"
"Csharp", ""
Expected Output:
Hi
PP
JS
C#

78. Write a C# Sharp program to combine two given strings (lowercase). If there are any double characters in the string, omit one character.

Sample Input:
"abc", "cat"
"python", "php"
"php", "php"
Expected Output:
abcat
pythonphp
phphp

79. Write a C# Sharp program to create a new string from a given string after swapping the last two characters.

Sample Input:
"Hello"
"Python"
"PHP"
"JS"
"C"
Expected Output:
Helol
Pythno
PPH
SJ
C

80. Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'. If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return an empty string.

Sample Input:
"abc"
"abcdef"
"C"
"xyz"
"xyzsder"
Expected Output:
abc
abc

xyz
xyz

81. Write a C# Sharp program to check whether the first two characters and the last two characters of a given string are the same.

Sample Input:
"abab"
"abcdef"
"xyzsderxy"
Expected Output:
True
False
True

82. Write a C# Sharp program to combine two given strings. If the given strings have different lengths remove the characters from the longer string.

Sample Input:
"abc", "abcd"
"Python", "Python"
"JS", "Python"
Expected Output:
abcbcd
PythonPython
JSon

83. Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string. If the string length is less than 2 use the whole string.

Sample Input:
"abc"
"Python"
"J"
Expected Output:
ababab
PyPyPy
JJJ

84. Write a C# Sharp program to create a new string from a string. In the case that the two characters at the beginning and end of the given string are the same, return the given string without the first two characters, otherwise return the original string.

Sample Input:
"abcab"
"Python"
Expected Output:
cab
Python

85. Write a C# Sharp program to create a new string from a given string without the first two characters. Keep the first character if it is "p" and keep the second character if it is "y".

Sample Input:
"abcab"
"python"
"press"
"jython"
Expected Output:
cab
python
pess
ython

86. Write a C# Sharp program to create a string from a given string without the first and last character. This is if the first or last characters are 'a' otherwise return the original given string.

Sample Input:
"abcab"
"python"
"abcda"
"jython"
Expected Output:
bcab
python
bcd
jython

87. Write a C# Sharp program to create a new string from a given string. Return the string without the first or first two 'a' characters otherwise return the original string.

Sample Input:
"abcab"
"python"
"aacda"
"jython"
Expected Output:
bcab
python
cda
jython

88. Write a C# Sharp program to check a given array of integers of length 1 or more. Return true if 10 appears as either the first or last element in the given array.

Sample Input:
{ 10, 20, 40, 50 }
{ 5, 20, 40, 10 }
{ 10, 20, 40, 10 }
{ 12, 24, 35, 55 }
Expected Output:
True
True
True
False

89. Write a C# Sharp program to check a given array of integers of length 1 or more. Return true if the first and the last element in the array are equal.

Sample Input:
{ 10, 20, 40, 50 }
{ 10, 20, 40, 10 }
{ 12, 24, 35, 55 }
Expected Output:
False
True
False

90. Write a C# Sharp program to check two given arrays of integers of length 1 or more. Return true if they have the same first element or the same last element.

Sample Input:
{ 10, 20, 40, 50 }, { 10, 20, 40, 50 }
{ 10, 20, 40, 50 }, { 10, 20, 40, 5 }
{ 10, 20, 40, 50 }, { 1, 20, 40, 5 }
Expected Output:
True
True
False

91. Write a C# Sharp program to compute the sum of the elements of an array of integers.

Sample Input:
{ 10, 20, 30, 40, 50 }
{ 10, 20, -30, -40, 50 }
Expected Output:
150
10

92. Write a C# Sharp program to rotate the elements of a given array of integers (length 4 ) in the left direction and return the array.

Sample Input:
{ 10, 20, -30, -40 }
Expected Output:
Rotated array: 20 -30 -40 10


93. Write a C# Sharp program to reverse a given array of integers and length 5.

Sample Input:
{ 10, 20, -30, -40, 50 }
Expected Output:
Reverse array: 50 -40 -30 20 10

94. Write a C# Sharp program to find out the maximum element between the first and last element in a given array of integers ( length 4), replace all elements with the maximum element.

Sample Input:
{ 10, 20, -30, -40 }
Expected Output:
New array: 20 20 20 20

95. Write a C# Sharp program to create an array containing the middle elements from the two given arrays of integers, each length 5.

Sample Input:
{ 10, 20, -30, -40, 30 }, { 10, 20, 30, 40, 30 }
Expected Output:
New array: -30 30

96. Write a C# Sharp program to create an array taking the first and last elements of a given array of integers and length 1 or more.

Sample Input:
{ 10, 20, -30, -40, 30 }
Expected Output :
New array: 10 30

97. Write a C# Sharp program to check if an array of integers length 2 contains 15 or 20.

Sample Input:
{ 12, 20 }
{ 14, 15 }
{ 11, 21 }
Expected Output :
True
True
False

98. Write a C# Sharp program to check if an array of integers with length 2 does not contain 15 or 20.

Sample Input:
{ 12, 20 }
{ 14, 15 }
{ 11, 21 }
Expected Output :
False
False
True

99. Write a C# Sharp program to create an array of integers with a length of 1 or more. The array length will be double the given array length. All the elements are 0 except the first element which is equal to the given array.

Sample Input:
{ 10, 20, -30, -40, 30 }
Expected Output :
New array: 10 0 0 0 0 0 0 0 0 0

100. Write a C# Sharp program to check a given array of integers and return true if it contains 10 or 20 twice. The array length will be 0, 1, or 2.

Sample Input:
{ 12, 20 }
{ 20, 20 }
{ 10, 10 }
{ 10 }
Expected Output :
False
True
True
False

101. Write a C# Sharp program to check a given array of integers length 3 and create a array. If there is a 5 in the given array immediately followed by a 7 then set 7 to 1.

Sample Input:
{ 1, 5, 7 }
Expected Output :
Original array:  1, 5, 7
New array: 1 5 1

102. Write a C# Sharp program to compute the sum of the two given arrays of integers, length 3. Find the array with the largest sum.

Sample Input:
{ 10, 20, -30 }, { 10, 20, 30 }
Expected Output :
Original array:  1, 5, 7
Larger array: 10 20 30

103. Write a C# Sharp program to create an array taking two middle elements from a given array of integers of length even.

Sample Input:
{ 1, 5, 7, 9, 11, 13 }
Expected Output:
Original array: 1, 5, 7, 9, 11, 13
New array: 7 9

104. Write a C# Sharp program to create an array from two arrays of integers, each length 3.

Sample Input:
{ 10, 20, 30 }, { 40, 50, 60 }
Expected Output :

Array 1: 10, 20, 30
Array 2: 40, 50, 60
New array: 10 20 30 40 50 60

105. Write a C# Sharp program to create an array by swapping the first and last elements of a given array of integers with a length of at least 1.

Sample Input:
{ 1, 5, 7, 9, 11, 13 }
Expected Output :
Original array: 1, 5, 7, 9, 11, 13
After swapping first and last elements: 13 5 7 9 11 1

106. Write a C# Sharp program to create an array length 3 from a given array (length at least 3) using the elements in the middle of the array.

Sample Input:
{ 1, 5, 7, 9, 11, 13 }
Expected Output :
Original array: 1, 5, 7, 9, 11, 13
New array: 7 9 11

107. Write a C# Sharp program to find the largest value from first, last, and middle elements of a given array of integers of odd length (at least 1).

Sample Input:
{1}
{1,2,9}
{1,2,9,3,3}
{1,2,3,4,5,6,7}
{1,2,2,3,7,8,9,10,6,5,4}
Expected Output :
1
9
9
7
8

108. Write a C# Sharp program to create an array by taking the first two elements from an array. If the given array length is shorter than 2, return the given array.

Sample Input:
{ 1, 5, 7, 9, 11, 13 }
Expected Output :
New array: 1 5

109. Write a C# Sharp program to count the even number of elements in a given array of integers.

Sample Input:
{ 1, 5, 7, 9, 10, 12 }
Expected Output :
Original array: 1, 5, 7, 9, 10, 12
2

110. Write a C# Sharp program to compute the difference between the largest and smallest values in a given array of integers and lengths of one or more.

Sample Input:
{ 1, 5, 7, 9, 10, 12 }
Expected Output:

Original array: 1, 5, 7, 9, 10, 12 
Difference between the largest and smallest values: 
11

111. Write a C# Sharp program to compute the sum of values in a given array of integers except 17. Return 0 if the given array has no integers.

Sample Input:
{ 1, 5, 7, 9, 10, 17 }
Expected Output :
Original array: 1, 5, 7, 9, 10, 17
Sum of values in the array of integers except the number 17: 
32

112. Write a C# Sharp program to compute the sum of the numbers in a given array except those that begin with 5 followed by at least one 6. Return 0 if the given array has no integers.

Sample Input:
{ 5, 6, 1, 5, 6, 9, 10, 17, 5, 6 }
{ 5, 6, 1, 5, 6, 9, 10, 17 }
{ 1, 5, 6, 9, 10, 17, 5, 6 }
{ 1, 5, 9, 10, 17, 5, 6 }
{ 1, 5, 9, 10, 17, 5}
Expected Output :
Sum of the numbers of the said array except those numbers starting with 5 followed by atleast one 6: 
37
37
37
42
47

113. Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere.

Sample Input:
{ 1, 5, 6, 9, 10, 17 }
{ 1, 5, 5, 9, 10, 17 }
{ 1, 5, 5, 9, 10, 17, 5, 5 }
Expected Output :
False
True
True

114. Write a C# Sharp program to check whether a given array of integers contains 5's and 7's.

Sample Input:
{ 1, 5, 6, 9, 10, 17 }
{ 1, 4, 7, 9, 10, 17 }
{ 1, 1, 2, 9, 10, 17}
Expected Output :
True
True
False

115. Write a C# Sharp program to check if the sum of all 5' in the array is exactly 15 in a given array of integers.

Sample Input:
{ 1, 5, 6, 9, 10, 17 }
{ 1, 5, 5, 5, 10, 17 }
{ 1, 1, 5, 5, 5, 5}
Expected Output :
False
True
False

116. Write a C# Sharp program to check if the number of 3's is greater than the number of 5's.

Sample Input:
{ 1, 5, 6, 9, 3, 3 }
{ 1, 5, 5, 5, 10, 17 }
{ 1, 3, 3, 5, 5, 5}
Expected Output :
True
False
False

117. Write a C# Sharp program to check if a given array of integers contains a 3 or a 5.

Sample Input:
{ 5, 5, 5, 5, 5 }
{ 3, 3, 3, 3 }
{ 3, 3, 3, 5, 5, 5}
{ 1, 6, 8, 10}
Expected Output :
True
True
True
False

118. Write a C# Sharp program to check if a given array of integers contains no 3 or 5.

Sample Input:
{ 5, 5, 5, 5, 5 }
{ 3, 3, 3, 3 }
{ 3, 3, 3, 5, 5, 5}
{ 1, 6, 8, 10}
Expected Output :
True
True
False
True

119. Write a C# Sharp program to check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both.

Sample Input:
{ 5, 5, 5, 5, 5 }
{ 1, 2, 3, 4 }
{ 3, 3, 5, 5, 5, 5}
{ 1, 5, 5, 7, 8, 10}
Expected Output :
True
False
True
True

120. Write a C# Sharp program to check a given array of integers. Return true if the given array contains two 5's next to each other, or two 5's separated by one element.

Sample Input:
{ 5, 5, 1, 5, 5 }
{ 1, 2, 3, 4 }
{ 3, 3, 5, 5, 5, 5}
{ 1, 5, 5, 7, 8, 10}
Expected Output :
True
False
True
True

121. Write a C# Sharp program to check a given array of integers and return true if there is a 3 with a 5 somewhere later in the given array.

Sample Input:
{ 3, 5, 1, 3, 7 }
{ 1, 2, 3, 4 }
{ 3, 3, 5, 5, 5, 5}
{ 2, 5, 5, 7, 8, 10}
Expected Output :
True
False
True
False

122. Write a C# Sharp program to check a given array of integers. Return true if the given array contains 2 even or 2 odd values all next to each other.

Sample Input:
{ 3, 5, 1, 3, 7 }
{ 1, 2, 3, 4 }
{ 3, 3, 5, 5, 5, 5}
{ 2, 4, 5, 6}
Expected Output :
True
False
True
True

123. Write a C# Sharp program to check a given array of integers and return true if 5 appears 5 times. There are no 5 next to each other.

Sample Input:
{ 3, 5, 1, 5, 3, 5, 7, 5, 1, 5 }
{ 3, 5, 5, 5, 5, 5, 5 }
{ 3, 5, 2, 5, 4, 5, 7, 5, 8, 5 }
{ 2, 4, 5, 5, 5, 5 }
{ 3, 5, 5, 5, 5, 5, 5, 5, 5, 5 }
Expected Output :
True
False
True
False
False

124. Write a C# Sharp program to check a given array of integers. Return true if every 5 in the given array is next to another 5.

Sample Input:
{ 3, 5, 5, 3, 7 }
{ 3, 5, 5, 4, 1, 5, 7}
{ 3, 5, 5, 5, 5, 5}
{ 2, 4, 5, 5, 6, 7, 5}
Expected Output :
True
False
True
False

125. Write a C# Sharp program to check a given array of integers. Return true if the specified number of same elements appears at the start and end of the given array.

Sample Input:
{ 3, 7, 5, 5, 3, 7 }, 2
{ 3, 7, 5, 5, 3, 7 }, 3
{ 3, 7, 5, 5, 3, 7, 5 }, 3
Expected Output :
True
False
True

126. Write a C# Sharp program to check a given array of integers and return true if the array contains three increasing adjacent numbers.

Sample Input:
{ 1, 2, 3, 5, 3, 7 }
{ 3, 7, 5, 5, 3, 7 }
{ 3, 7, 5, 5, 6, 7, 5 }
Expected Output :
True
False
True

127. Write a C# Sharp program to shift an element left and return an array.

Sample Input:
{ 10, 20, -30, -40, 50 }
Expected Output :
New array: 20 -30 -40 50 10

128. Write a C# Sharp program to create an array taking the elements before 5 from a given array of integers.

Sample Input:
{ 1, 2, 3, 5, 7 }
Expected Output :
New array: 1 2 3

129. Write a C# Sharp program to create an array by taking the elements after element value 5 from a given array of integers.

Sample Input:
{ 1, 2, 3, 5, 7, 9, 11 }
Expected Output :
New array: 7 9 11

130. Write a C# Sharp program to create an array from a given array of integers by shifting all zeros to the left direction.

Sample Input:
{ 1, 2, 0, 3, 5, 7, 0, 9, 11 }
Expected Output :
New array: 0 0 1 3 5 7 2 9 11

131. Write a C# Sharp program to create an array after replacing all values 5 with 0 and shifting all zeros to the right.

Sample Input:
{ 1, 2, 5, 3, 5, 7, 5, 9, 11 }
Expected Output :
New array: 1 2 3 7 9 11 0 0 0

132. Write a C# Sharp program to create an array from a given array of integers. Shift all even numbers before all odd numbers.

Sample Input:
{ 1, 2, 5, 3, 5, 4, 6, 9, 11 }
Expected Output :
New array: 2 4 6 3 5 1 5 9 11

133. Write a C# Sharp program to check if the value of each element is equal or greater than the value of the previous element in a given array of integers.

Sample Input:
{ 5, 5, 1, 5, 5 }
{ 1, 2, 3, 4 }
{ 3, 3, 5, 5, 5, 5}
{ 1, 5, 5, 7, 8, 10}
Expected Output:
False
True
True
True

134. Write a C# Sharp program to check a given array (length will be at least 2) of integers and return true if there are two values 15, 15 next to each other.

Sample Input:
{ 5, 5, 1, 15, 15 }
{ 15, 2, 3, 4, 15 }
{ 3, 3, 15, 15, 5, 5}
{ 1, 5, 15, 7, 8, 15}
Expected Output :
True
False
True
False

135. Write a C# Sharp program to find the largest average value between the first and second half of a given array of integers. Minimum length is at least 2. Assume that the second half begins at index (array length)/2.

Sample Input:
{ 1, 2, 3, 4, 6, 8 }
{ 15, 2, 3, 4, 15, 11 }
Expected Output:
6
10

136. Write a C# Sharp program to count the number of strings with given lengths in a given array of strings.

Sample Input:
{"a", "b", "bb", "c", "ccc" }, 1
Expected Output:
Number of Strings: 
3

137. Write a C# Sharp program to create an array using the first n strings from a given array of strings. (n>=1 and <=length of the array).

Sample Input:
{"a", "b", "bb", "c", "ccc" }, 3
Expected Output :
New array: a b bb

138. Write a C# Sharp program to create an array from a given array of strings. This is done using all the strings whose lengths matches given string length.

Sample Input:
{"a", "aaa", "b", "bbb", "c", "ccc" }, 3
Expected Output :
New array: aaa bbb ccc

139. Write a C# Sharp program to check a positive integer and return true if it contains a number 2.

Sample Input:
123
13
222
Expected Output:
True
False
True

140. Write a C# Sharp program to create an array of given length using odd numbers from a given array of positive integers.

Sample Input:
{1,2,3,5,7,9,10},3
Expected Output:
New array: 1 3 5

141. Write a C# Sharp program to create a list from a given list of integers where each element is multiplied by 3.

Sample Input:
{ 1, 2, 3 , 4 }
Expected Output :
New array: 3 6 9 12

142. Write a C# Sharp program to create a list from a given list of integers. Each integer is multiplied by itself three times.

Sample Input:
{ 1, 2, 3 , 4 }
Expected Output:
New array: 1 8 27 64

143. Write a C# Sharp program to create a list from a given list of strings. Each element has "#" added at the beginning and end position.

Sample Input:
{ "1", "2", "3" , "4" }
Expected Output :
#1# #2# #3# #4#

144. Write a C# Sharp program to create a list from a given list of strings. Each element is replaced by 4 copies of the string concatenated together.

Sample Input:
{ "1", "2", "3" , "4" }
Expected Output :
1111 2222 3333 4444

145. Write a C# Sharp program to create a list from a given list of integers. In this program, each integer value is added to 2 and the resulting value is multiplied by 5.

Sample Input:
{ 1, 2, 3 , 4 }
Expected Output :
15 20 25 30

146. Write a C# Sharp program to create a list of the rightmost digits from a given list of positive integers.

Sample Input:
{ 10, 22, 35 , 41 }
Expected Output:
0 2 5 1

147. Write a C# Sharp program to create a list from a given list of strings. Strings will be in upper case in the new string.

Sample Input:
{ "Abc", "cdef", "js" , "php" }
Expected Output :
ABC CDEF JS PHP

148. Write a C# Sharp program to remove all "a"s from each string in a given list of strings and return the result string.

Sample Input:
{ "abc", "cdaef", "js" , "php" }
Expected Output :
bc cdef js php

149. Write a C# Sharp program to create a list from a given list of integers removing those values less than 4.

Sample Input:
{ 0, -2, 1, 2, 3, 5 , 4, 7, 8 }
Expected Output :
0 -2 1 2 3

150. Write a C# Sharp program to create a list from a given list of integers, removing all values ending in 7.

Sample Input:
{ 10, 22, 35 , 47, 53, 67 }
Expected Output :
10 22 35 53