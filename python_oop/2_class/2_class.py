class Car:
    brand = "Audi"

# print(type (Car))
# print(Car.brand)

newCar1 = Car()
newCar2 = Car()

print(type (newCar1))
print("newCar1 is", newCar1.brand)

print(type (newCar2))
print("newCar2 is", newCar2.brand)
newCar2.brand = "BMW"
print("changing brand for newCar2")
print("newCar2 is", newCar2.brand)

print("adding engine for newCar2")
newCar2.engine = "v8"
print("engine for newCar2 is", newCar2.engine)
print("######################")

print("__dict__ for Car class")
print (Car.__dict__)

print (Car().__dict__)

print ("setattr for class Car")
setattr (Car, 'newattr', 1.8)
print (Car.__dict__)

print ("print class Car:", Car)
print ("print class Car():", Car())
print ("print instance newCar1:", newCar1)
print ("newCar1.__dict__:", newCar1.__dict__)
print ("newCar2.__dict__:", newCar2.__dict__)

print ("newCar1.newattr:", newCar2.newattr)


print("######################")
#добавляем аттрибут в класс Car, при этом этот аттрибут появляется у всех экзепляров класса.

Car.x = 100
print("newCar1.x: ",newCar1.x)
print("newCar2.x: ",newCar2.x)

print("######################\n")
#добавляем определение функции в класс.

class Machine:
    #machineType = NULL

    @staticmethod
    def sayHello():
        print ("Say Hello!", )

print('1Machine.sayHello', Machine.sayHello )
print('2Machine.__dict__:\n', Machine.__dict__, '\n')
print('3Machine.sayHello()', Machine.sayHello() )

print("######################\n")
#создаем экземпляр класса на основе Machine

a1 = Machine()
print(a1.sayHello())




print("######################\n")

# class Cat:
#     def hi():
#         print ("hihihi")

# kisa = Cat()
# kisa.hi()

print("######################\n")

class Cat:
    def hi(*args):
        print ("hihihi", args)

kisa = Cat()
kisa.hi()
print('kisa address is:', kisa)
#print(Cat())

bob = Cat()
bob.hi()
print('bob address is:', bob)

print("######################\n")

print("######################\n")
#функция добавления аттрибутов в экземпляр класса.

class Device:
    #функция вывода типа устройства.
    def typeOfDevice(self):
        print (f'Device type is {self.name}')

    #функция добавления аттрибутов в экземпляр класса.
    def setValue(self, name, year):
        self.name = name
        self.year = year

mobile = Device()
print('before setValue():',mobile.__dict__)
mobile.setValue('Tablet', 2001)
print('after  setValue():',mobile.__dict__)
mobile.typeOfDevice()
