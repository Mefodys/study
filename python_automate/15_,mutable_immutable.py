#mutable - изменяемый
#immutable - неизменяемый

# list is mutable (изменять можно)
# string is immutable (изменять нельзя)
# typle is immutable (изменять нельзя)

name = 'kukareku'
print ('name is', name)
print('the second symbol in name is', name[1])
# name[1] = 'q'  - не сработает.
print('name',id(name))

new_name = name[:1] + 'Q' + name[2:]
print (new_name)
print('new_name',id(new_name))

print()

eggs=[1,2,3]
print('eggs',eggs, id(eggs))
eggs=[4,5,6]
print('eggs',eggs, id(eggs))

del eggs[0]
print('eggs',eggs, id(eggs))
eggs.append(10)
print('eggs',eggs, id(eggs))

print()

# в квадратных скобках - список. (изменяемый)
# в круглых    скобках - кортеж. (неизменяемый)

var = 10
print(id(var))
bar = var
print(id(bar))

var = var - 1
print(id(var))
print(id(bar))

print()
new_list = [1,2,3,4,5]
print(new_list, id(new_list))
new_list2 = new_list
print(new_list2, id(new_list2))
new_list.append(10)
print(new_list2, id(new_list2))
