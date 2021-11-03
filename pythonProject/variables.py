x="Hello"
print(x)
print(id(x))
print(dir(x))
#last
l1=dir(x)
for i in l1:
    print(i)
#help(dir)

y=1
print(type(y))
y = y.__add__(5)
print("y after __add__", y)
#help(print)
help(print())
