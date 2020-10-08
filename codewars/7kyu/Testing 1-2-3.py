# 7 kyu
# Testing 1-2-3

"""
Your team is writing a fancy new text editor and you've been tasked with implementing the line numbering.

Write a function which takes a list of strings and returns each line prepended by the correct number.

The numbering starts at 1. The format is n: string. Notice the colon and space in between.

Examples:

number([]) # => []
number(["a", "b", "c"]) # => ["1: a", "2: b", "3: c"]
"""


# def number(lines):
#     count = 0
#     r = {}
#
#     for i in lines:
#         count += 1
#         r[count] = i
#     print(r)
#     for i in r:
#         print(i,r[i])
#     print(t)


#WORKS!
# def number(lines):
#     count = 0
#     temp_string = ""
#     temp_list = []
#
#     for i in lines:
#         count += 1
#         temp_string = str(count) + ": " + i
#         temp_list.append(temp_string)
#
#     print(temp_list)

#Shorter variant
def number(lines):
    count = 0
    temp_list = []

    for i in lines:
        count += 1
        temp_list.append(str(count) + ": " + i)

    print(temp_list)




number([])  # , []
number(["a", "b", "c"])  # ["1: a", "2: b", "3: c"]
