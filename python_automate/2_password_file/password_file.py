#1 straight open of the file
print ("----------")
print ("straight open of the file:")
password = open("C:\py\study\python_automate\\2_password_file\secretpass.txt","r")  #used double slash (!)
second_password = open("C:\py\study\python_automate\\2_password_file\\file_with_password.txt","r")  #used double slash (!)

print ("file object in python -> ", password)
print ("readed file with password -> ", password.read())
print ("file object in python -> ", second_password)
print ("readed file with password -> ", second_password.read())



#2 open the file using with expression
print ("----------")
print ("open the file using with expression:")
with open("C:\py\study\python_automate\\2_password_file\secretpass.txt", "r") as f:
    data = f.read()
print(data)



#3 open file in UTF8
print ("----------")
import io
f = io.open("C:\py\study\python_automate\\2_password_file\\file_with_password.txt", mode="r", encoding="utf-8")
print ("file object in python -> ", f)
print ("readed file with password -> ", f.read())