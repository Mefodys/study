cats = ['Marry', 'Poppins', 'Tail']

name = input('Enter cat name: ')
if name not in cats:
    cats.append(name)

print(cats)
