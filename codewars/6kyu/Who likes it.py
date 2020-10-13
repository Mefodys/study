def likes(names):
    count = len(names)
    if count == 0:
        return 'no one likes this'
    elif count == 1:
        return names[0] + ' likes this'
    elif count == 2:
        return names[0] + " and " + names[1] + ' like this'
    elif count == 3:
        return names[0] + ", " + names[1] + " and " + names[2] + ' like this'
    else:
        return(names[0] + ", " + names[1] + " and " + str(count-2) + ' others like this')

likes([])  # , 'no one likes this')
likes(['Peter'])  # , 'Peter likes this')
likes(['Jacob', 'Alex'])  # , 'Jacob and Alex like this')
likes(['Max', 'John', 'Mark'])  # , 'Max, John and Mark like this')
likes(['Alex', 'Jacob', 'Mark', 'Max'])  # , 'Alex, Jacob and 2 others like this')
