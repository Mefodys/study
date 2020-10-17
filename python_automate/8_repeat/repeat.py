#data types

# x = 10
# print(x, type(x), id(x))

# y = x

# print('x', x, type(x), id(x))
# print('y', y, type(y), id(y))

# y += 1
# print('x', x, type(x), id(x))
# print('y', y, type(y), id(y))

# x = "hi"
# print('x', x, type(x), id(x))

# x = (dir(x))
# print('x', x, type(x), id(x))

# print(dir(x))

###
a = 5
print('a', a, type(a), id(a))
# print(dir(a))

a = 'hi'
print('a', a, type(a), id(a))
# print(dir(a))
a = a + "friend"
print('a', a, type(a), id(a))

b = [1,2,3,4,5]
print('b', b, type(b), id(b))
# print(dir(b))
b.append(6)
print('b', b, type(b), id(b))

c = (1,2,3,4,5)
print('c', c, type(c), id(c))

d = range(6)
print('d', d, type(d), id(d))

e = {"name" : "John", "age" : 36}
print('e', e, type(e), id(e))

f = {"apple", "banana", "cherry"}
print('f', f, type(f), id(f))
u = (dir(f))

for i in u:
    print(i)

###

a = "Hi"
print (a, id(a))
a *= 2
print (a, id(a))

#mutable: list, dict, set