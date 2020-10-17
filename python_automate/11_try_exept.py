# def func(number):
#     return 42 / number
#
# print(func(2))
# print(func(21))
# print(func(0)) # faulty case.

# =====

# def func(number):
#     try:
#         return 42 / number
#     # except:
#     except ZeroDivisionError:
#         print('An invalid number entered')
#
# print(func(2))
# print(func(21))
# print(func(0)) # faulty case.
# print(func(1))


# =====  if except code workes, then next code in try does not executed. Executed only part after except.
def func(number):
    return 42 / number

try:
    print(func(2))
    print(func(21))
    print(func(0))  # faulty case.
    print(func(1))

# except:
except ZeroDivisionError:
    print('An invalid number entered')




