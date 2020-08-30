#object - экземпляр класса

a= [1,2,3]
print(type(a))

print(isinstance(a, list))
print(isinstance(a, type))

print(type(list))
print(type(type))

class Car:
    model = "Skoda"
    engine = 1.8

a = Car()
print(type(a))

# Аттрибуты класса

class Person:
    name = "Anton"
    age = 30


newPerson = Person()
print (newPerson.name)
print (newPerson.age)

print (Person.__dict__)
print (newPerson.__dict__)