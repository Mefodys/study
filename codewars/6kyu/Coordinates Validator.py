#!NOT COMPLETED!
#Regular Expression from pat works on https://regexr.com/ with all stings instead of "99.234, 12.324"
#Here it shows True for "6.325624, 43.34345.345", "0, 1,2", "23.245, 1e1" somewhy.

# 6 kyu
# Coordinates Validator

"""
You need to create a function that will validate if given parameters are valid geographical coordinates.
Valid coordinates look like the following: "23.32353342, -32.543534534". The return value should be either true or false.
Latitude (which is first float) can be between 0 and 90, positive or negative. Longitude (which is second float) can be between 0 and 180, positive or negative.
Coordinates can only contain digits, or one of the following symbols (including space after comma) __ -, . __
There should be no space between the minus "-" sign and the digit after it.
Here are some valid coordinates:
-23, 25
24.53525235, 23.45235
04, -23.234235
43.91343345, 143
4, -3

And some invalid ones:
23.234, - 23.4234
2342.43536, 34.324236
N23.43345, E32.6457
99.234, 12.324
6.325624, 43.34345.345
0, 1,2
0.342q0832, 1.2324
"""

coordinates = [
    "-23, 25",
    "4, -3",
    "24.53525235, 23.45235",
    "04, -23.234235",
    "43.91343345, 143",
    "23.234, - 23.4234",
    "2342.43536, 34.324236",
    "N23.43345, E32.6457",
    "99.234, 12.324",
    "6.325624, 43.34345.345",
    "0, 1,2",
    "0.342q0832, 1.2324",
    "23.245, 1e1"
]

import re

#pat = '-?[0-9]?[0-9]\.?([0-9]+)?,\s-?[0-1]?[0-9]?[0-9]\.?(([0-9])+)??'
correct_pat = '-?(\d|[1-8]\d|90)\.?\d*, -?(\d|[1-9]\d|1[0-7]\d|180)\.?\d*$'


# def is_valid_coordinates(coordinates):
#     for i in coordinates:
#         if re.match(pat, i):
#             print("TRUE", i)
#         else:
#             print("False", i)

# solution:
def is_valid_coordinates(coordinates):
    for i in coordinates:
        x = bool(re.match(correct_pat, i))
        print (x, i)
        #return bool(re.match(correct_pat, i))

is_valid_coordinates(coordinates)

#problem was with my understading of the task.
#the func must receive one sting (a pair of coordinates),
#not a list with a bunch of pairs with coordinates.
