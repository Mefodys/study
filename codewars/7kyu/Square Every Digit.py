def square_digits(num):
    res = [(int(x)) ** 2 for x in str(num)]
    print(res)
    s = [str(i) for i in res]
    t = "".join(s)

    print(int(t))

#SMARTER SOLUTION:
# def square_digits(num):
#     ret = ""
#     for x in str(num):
#         ret += str(int(x)**2)
#     return int(ret)

square_digits(9119)
