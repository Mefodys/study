# 6 kyu
# Count the smiley faces!

"""
Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.

Rules for a smiling face:

Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
Every smiling face must have a smiling mouth that should be marked with either ) or D
No additional characters are allowed except for those mentioned.

Valid smiley face examples: :) :D ;-D :~)
Invalid smiley faces: ;( :> :} :]

Example
countSmileys([':)', ';(', ';}', ':-D']);       // should return 2;
countSmileys([';D', ':-(', ':-)', ';~)']);     // should return 3;
countSmileys([';]', ':[', ';*', ':$', ';-D']); // should return 1;
Note
In case of an empty array return 0. You will not be tested with invalid input (input will always be an array). Order of the face (eyes, nose, mouth) elements will always be the same.
"""

"""
import re

smiley_face_pattern = '[:|;]([-|~])?[)|D]$'


def count_smileys(arr):
    count = 0
    if arr:
        for i in arr:
            x = re.match(smiley_face_pattern, i)
            if x:
                count += 1
        print(count)
    else:
        print(0)

"""



# Another solutions from codewars:
#
from re import findall
def count_smileys(arr):
    return len(findall(r"[:;][-~]?[)D]", " ".join(arr)))


# STEP-BY-STEP:
# from re import findall
# def count_smileys(arr):
#      a = " ".join(arr)
#      b = findall(r"[:;][-~]?[)D]", a)
#      c = list(b)
#      d = len (c)
#      print (d)


count_smileys([])                              # 0)
count_smileys([':D',':~)',';~D',':)'])         # 4)
count_smileys([':)',':(',':D',':O',':;'])      # 2)
count_smileys([';]', ':[', ';*', ':$', ';-D']) # 1)