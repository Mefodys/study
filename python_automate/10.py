# import random
#
# l = []
# for i in range(5):
#     l.append(random.randint(1,10))
# print(l)

# ===

# import sys
#
# if __name__ == '__main__':
#     print(__name__)
#     while True:
#         print('PRINT: Type exit to exit')
#         response = input()
#         if response == 'exit':
#             sys.exit()
#         print('You typed ' + response)

# ===


# while True:
#     option = int(input('Enter number 1 or 2 or 3 and press Enter\n'))
#     if option == 1:
#         print ('Hello')
#         break
#     elif option == 2:
#         print('Howdy')
#         break
#     elif option == 3:
#         print('Greeting')
#         break
#     else:
#         print('You have enterned not 1 or 2 or 3. Please enter number 1 or 2 or 3 and press Enter\n')
# #

# # ===
#
# for i in range(3):
#     print(i)
#
# for i in range(0, 3):
#     print(i)
#
# for i in range(0, 10, 2):
#     print(i)

# ===
# x = 1
# while x <= 10:
#     print(x)
#     x += 1

# ===
# import random
#
#
# def fortuneball(number):
#     if number == 1:
#         return 'OK'
#     elif number == 2:
#         return 'Not sure'
#     elif number == 3:
#         return 'NO'
#
# attempt_count = int(input('Input number of attempts to shake fortune ball:  '))
# for i in range(attempt_count):
#     r = random.randint(1, 3)
#     fortune = fortuneball(r)
#     print('Attempt '+ str(i) + ' ' +fortune)
#     # print(fortuneball(r))

# ===
# print(type(None))
# print(dir(None))
# print(dir(print(10)))

def spam():
    global eggs
    eggs = "spam local eggs marked as global"
    print (eggs)

def bacon():
    eggs = 'bacon local eggs'
    print (eggs)
    spam()
    print (eggs)

eggs = 'global eggs'
bacon()
print (eggs)