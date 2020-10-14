"""
A pangram is a sentence that contains every single letter of the alphabet at least once.
For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram,
because it uses the letters A-Z at least once (case is irrelevant).
Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.
"""

# import string
#
# def is_pangram(s):
#     a = "abcdefghijklmnopqrstuvwxyz"
#
#     for i in s.lower():
#         if i.isalpha() and a.count(i) == 1:
#             print("ok")
#         else:
#             print("not ok")

# import string
#
# def is_pangram(s):
#     a = "abcdefghijklmnopqrstuvwxyz"
#     flag = 0
#     st = ''.join(e for e in s if e.isalnum())
#     st1 = st.lower()
#
#     print('e', st1.count('e'))
#
#     for i in a:
#         if st1.count(i) <= 1:
#             flag = 1
#
#     if flag == 1:
#         print("Not OK")
#     print ("OK")

# if a.count(i) >= 1
#     return True
# else:
#     return False


def is_pangram(s):
    a = "abcdefghijklmnopqrstuvwxyz"
    st = ''.join(e.lower() for e in s if e.isalnum())

    for i in a:
        if i and st.count(i) == 0:
            return False
    return True






pangram = 'The quick, brown fox jumps over the lazy dog!'
pangram1 = 'abcdefghijklmopqrstuvwxyz'
is_pangram(pangram)   # True


# st = 'hello'
# print (st)
# st = st.strip('h')
# print (st)




