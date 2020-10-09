"""
def dirReduc(arr):
    print(arr)
    t = {}
    res = []
    for i in arr:
        if i in t:
            t[i] += 1
        else:
            t[i] = 1
    print(t)
    print(t['NORTH'])

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
"""

"""
def dirReduc(arr):
    l = len(arr)
    for i in range(len(arr) - 1):
        if ((arr[i] == "NORTH") and (arr[i + 1] == "SOUTH")):
            arr.pop(i)
            arr.pop(i)
        elif ((arr[i] == "SOUTH") and (arr[i + 1] == "NORTH")):
            arr.pop(i)
            arr.pop(i)
        elif ((arr[i] == "WEST") and (arr[i + 1] == "EAST")):
            arr.pop(i)
            arr.pop(i)
        elif ((arr[i] == "EAST") and (arr[i + 1] == "WEST")):
            arr.pop(i)
            arr.pop(i)
    print(arr)
"""

"""
def dirReduc(arr):
    l = len(arr)
    i = 0
    j = 0
    x = []
    t = True
    while True:
        if (l <=1):
            x.append(arr[i])
            break
        else:
            if ((arr[i] == "NORTH") and (arr[i + 1] == "SOUTH")):
                arr.pop(i)
                arr.pop(i)
                l = (len(arr))
            elif ((arr[i] == "SOUTH") and (arr[i + 1] == "NORTH")):
                arr.pop(i)
                arr.pop(i)
                l = (len(arr))
            elif ((arr[i] == "WEST") and (arr[i + 1] == "EAST")):
                arr.pop(i)
                arr.pop(i)
                l = (len(arr))
            elif ((arr[i] == "EAST") and (arr[i + 1] == "WEST")):
                arr.pop(i)
                arr.pop(i)
                l = (len(arr))
            else:
                x.append(arr[i])
                arr.pop(i)
                j += 1
                l = (len(arr))

    print(x)
"""


def dirReduc(arr):
    i = 0
    l = len(arr)
    count = l
    while True:
        if len(arr) <= 1:
            break
        else:
            if ((arr[i] == "NORTH") and (arr[i + 1] == "SOUTH")) or ((arr[i] == "SOUTH") and (arr[i + 1] == "NORTH")) or ((arr[i] == "WEST") and (arr[i + 1] == "EAST")) or ((arr[i] == "EAST") and (arr[i + 1] == "WEST")):
                arr.pop(i)
                arr.pop(i)
                l = (len(arr))
                i = 0
            else:
                if i == (l - 2):
                    break
                else:
                    i += 1
    print(arr)

a = ["NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"]
b = ["NORTH", "WEST", "SOUTH", "EAST"]
dirReduc(a)  # ['WEST']
