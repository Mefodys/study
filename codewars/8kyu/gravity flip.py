def flip(d, a):
    print(type(a), dir(a))
    if d == 'R':
        a.sort()
        print (a)
    else:
        a.sort(reverse=True)
        print(a)
flip('R', [3, 2, 1, 2])         # [1, 2, 2, 3]
flip('L', [1, 4, 5, 3, 5])      # [5, 5, 4, 3, 1]