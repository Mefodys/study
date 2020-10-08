# 7 kyu
# Vowel Count

"""
Return the number (count) of vowels in the given string.
We will consider a, e, i, o, u as vowels for this Kata (but not y).
The input string will only consist of lower case letters and/or spaces.
"""


def get_count(input_str):
    num_vowels = 0
    for i in input_str:
        if i == "a" or i == "e" or i == "i" or i == "o" or i == "u":
            num_vowels += 1

    print(num_vowels)
    # return num_vowels

#smarter variant
# def getCount(s):
#     return sum(c in 'aeiou' for c in s)


get_count("abracadabra")  # 5
