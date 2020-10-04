# 7 kyu
# Sum of two lowest positive integers
""""
Create a function that returns the sum of the two lowest positive numbers
given an array of minimum 4 positive integers. No floats or non-positive integers will be passed.
For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
"""

def sum_two_smallest_numbers(numbers):
    return sorted(numbers)[0] + sorted(numbers)[1]

sum_two_smallest_numbers([5, 8, 12, 18, 22, 13])  # result is 5 + 8 = 13
