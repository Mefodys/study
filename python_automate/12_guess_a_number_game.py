import random

number = random.randint(1, 20)
attempts_number = 0
attempts_limit = 5

while True:
    if attempts_limit == 0:
        print('You have no more attempts. The number was ' + str(number) + '. THE GAME IS OVER')
        break
    else:
        try:
            print('You have ' + str(attempts_limit) + ' attempts')
            x = input('Make a guess of a number from 1 to 20. Type it and press Enter: ')
            x = int(x)
        except:
            print('ERROR: You have entered not a valid number (from 1 to 20)! Try again. ')
            continue

    attempts_number += 1
    attempts_limit -= 1

    if x < number:
        print('The number is bigger than your guess. Try again!')
        continue
    elif x > number:
        print('The number is smaller than your guess. Try again!')
    elif x == number:
        print('YOU ARE RIGHT!')
        print('Number of attempts: ', attempts_number)
        break
    # else:
    #     print('some unkown error. contact devs team')
    #     continue
