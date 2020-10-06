def square_digits(num):
    res = [(int(x)) ** 2 for x in str(num)] # [81, 1, 1, 81]
    return int("".join([str(i) for i in res]))


#SMARTER SOLUTION:
# def square_digits(num):
#     ret = ""
#     for x in str(num):
#         ret += str(int(x) ** 2)
#     # return int(ret)

#ANOTHER SOLUTION:
# def square_digits(num):
#     return int(''.join(str(int(c)**2) for c in str(num)))

square_digits(9119)

a=1
b="abcde"

print(dir(a))
print(dir(b))

print(str(a).join(b))

c = str(a) + b
print(c)