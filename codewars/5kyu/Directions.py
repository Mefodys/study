def dirReduc(arr):
    t = {}
    res = []
    for i in arr:
        if i in t:
            t[i] += 1
        else:
            t[i] = 1
    #print(t)
    #print(t['NORTH'])

    if t['NORTH'] == t['SOUTH']:
        t.pop('NORTH')
        t.pop('SOUTH')
    elif t['NORTH'] > t['SOUTH']:
        t['NORTH'] = t['NORTH'] - t['SOUTH']
        t.pop('SOUTH')
    elif t['SOUTH'] > t['NORTH']:
        t['SOUTH'] = t['SOUTH'] - t['NORTH']
        t.pop('NORTH')


    if t['EAST'] == t['WEST']:
        t.pop('EAST')
        t.pop('WEST')
    elif t['EAST'] > t['WEST']:
        t['EAST'] = t['EAST'] - t['WEST']
        t.pop('WEST')
    elif t['WEST'] > t['EAST']:
        t['WEST'] = t['WEST'] - t['EAST']
        t.pop('EAST')
    #print(t)

    for i in t:
        #print (i)
        res.append(i)
    print (res)
    #print(i,t[i])


a = ["NORTH", "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"]
dirReduc(a)  # ['WEST']
