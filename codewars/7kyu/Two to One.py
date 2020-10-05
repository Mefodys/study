# 7 kyu
# Two to One
"""
Take 2 strings s1 and s2 including only letters from ato z. Return a new sorted string, the longest possible, containing distinct letters,

each taken only once - coming from s1 or s2.
Examples:
a = "xyaabbbccccdefww"
b = "xxxxyyyyabklmopq"
longest(a, b) -> "abcdefklmopqwxy"

a = "abcdefghijklmnopqrstuvwxyz"
longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"
"""


def longest(s1, s2):
    t = ""
    s = sorted(set(s1 + s2))
    for i in s:
        t += (i)
    return t

#COOL SOLUTION:
# def longest(a1, a2):
#     return "".join(sorted(set(a1 + a2)))


longest("aretheyhere", "yestheyarehere")  # result is "aehrsty"
longest("loopingisfunbutdangerous", "lessdangerousthancoding")  # result is "abcdefghilnoprstu"
longest("inmanylanguages", "theresapairoffunctions")  # result is "acefghilmnoprstuy"
