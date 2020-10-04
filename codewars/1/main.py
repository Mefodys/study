#7 kyu
#Highest and Lowest
#return max and min value in sting.

def high_and_low(numbers):
    temp_list = [int(i) for i in numbers.split (" ")]
    return str(max(temp_list)) + " " + str(min (temp_list))

high_and_low("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6") # result should be "542 -214"