#self это параметр, который указывает на обьект.
#вывод self из метода показывает, что он указывает на созданный объект.

#метод __init__ инициализирует объект с параматрами, которые нам нужны. 

class Cat:

    def __init__(self):
        print('Hello, new object is', self)



tom = Cat()
print (tom)

print('\n')
jerry = Cat()
print(jerry)


print('\n===\nclass Dog\n')


class Dog:

    def __init__(self, name, age, color):
        print('Name is', name)
        print('Age is', age)
        print('Color is',  color)

Chelsi = Dog('Chelsi', 10, 'black')


class NewDog:

    def __init__(self, name, age, color):
        self.name = name
        self.age = age
        self.color = color
        
        print('Name is', name)
        print('Age is', age)
        print('Color is',  color)

Chelsi = Dog('Chelsi', 10, 'black')