# t = 123
t = 'abc'
# t = ['abc','def']
# t = ('abc','def')
#t = {'abc', 'def'}


def exclude_magic_methods(var):
    all_methods_list = (dir(var))
    q = [i for i in all_methods_list]
    for element in q:
        if element.startswith("__"):
            continue
        else:
            print(element)


exclude_magic_methods(t)
