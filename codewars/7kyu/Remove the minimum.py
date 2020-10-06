# 7 kyu
# Remove the minimum
"""
The museum of incredible dull things
The museum of incredible dull things wants to get rid of some exhibitions. Miriam, the interior architect, comes up with a plan to remove the most boring exhibitions. She gives them a rating, and then removes the one with the lowest rating.

However, just as she finished rating all exhibitions, she's off to an important fair, so she asks you to write a program that tells her the ratings of the items after one removed the lowest one. Fair enough.

Task
Given an array of integers, remove the smallest value. Do not mutate the original array/list. If there are multiple elements with the same value, remove the one with a lower index. If you get an empty array/list, return an empty array/list.

Don't change the order of the elements that are left.

Examples
remove_smallest([1,2,3,4,5]) = [2,3,4,5]
remove_smallest([5,3,2,1,4]) = [5,3,2,4]
remove_smallest([2,2,1,2,1]) = [2,2,2,1]
"""


def remove_smallest(numbers):
    if numbers:
        a = sorted(numbers)
        numbers.remove(a[0])
        print(numbers)
    else:
        return []

#was unable to solve kata, because the test said that numbers should not be mutated.
#the solution was:
# def remove_smallest(numbers):
#     if numbers:
#         a = sorted(numbers)
#         b = numbers[:]
#         b.remove(a[0])
#         print(b)
#     else:
#         return []


    # for i in numbers:
    # print(i)
# remove_smallest([5, 1, 2, 3, 4, 5])  # [2, 3, 4, 5]
# remove_smallest([5, 3, 2, 1, 4]) #, [5, 3, 2, 4]
# remove_smallest([1, 2, 3, 1, 1]) # [2, 3, 1, 1]
remove_smallest([364, 367, 70, 110, 375, 126])

#==
print()
a = [364, 367, 70, 110, 375, 126]
print ("a", id(a), a)

# b = []
b = a.copy()
print ("b" ,id(b), b)

c = a[:]
print ("c", id(c), c)
