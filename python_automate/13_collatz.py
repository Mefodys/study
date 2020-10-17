def collatz(number):
    if number % 2 == 0:
        a = number // 2
        return a
    elif number % 2 == 1:
        a = 3 * number + 1
        return a
    else:
        print('seems you have entered a zero value')
        return 'zero'


a = int(input('type a digit \'3\': '))
while a != 1:
    a = collatz(a)
    print(a)
