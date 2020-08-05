#test

#1 straight open of the file
print ("----------")
print ("straight open of the file:")
password = open("C:\py\study\python_automate\\2_password_file\secretpass.txt","r")  #used double slash (!)

print ("file object in python -> ", password)
print ("readed file with password -> ", password.read())




#2 open the file using with expression
print ("----------")
print ("open the file using with expression:")
with open("C:\py\study\python_automate\\2_password_file\secretpass.txt", "r") as f:
    data = f.read()
print(data)
