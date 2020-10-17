import random

number = random.randint(1, 20)

while True:
    x = input('Make a guess of a number from 1 to 20. Type it and press Enter: ')
    if x != None:
        try:
            x = int(x)
        except:
            print ('you entered not a valid number (from 1 to 20)!')
            break


        if x < number:
            print('The number is bigger than your guess. Try again!')
            continue
        elif x > number:
            print('The number is smaller than your guess. Try again!')
        elif x == number:
            print('You are right!')
            break
    # else:
    #     print('some unkown error. contact devs team')
    #     continue
