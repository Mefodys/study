#1 straight open of the file
print ("----------")
print ("#1 straight open of the file:")
password = open("C:\py\study\python_automate\\2_password_file\secretpass.txt","r")  #used double slash (!)
second_password = open("C:\py\study\python_automate\\2_password_file\\file_with_password.txt","r")  #used double slash (!)

print ("file object in python -> ", password)
print ("readed file with password -> ", password.read())
print ("file object in python -> ", second_password)
print ("readed file with password -> ", second_password.read())



#2 open the file using with expression
print ("----------")
print ("#2 open the file using with expression:")
with open("C:\py\study\python_automate\\2_password_file\secretpass.txt", "r") as f:
    data = f.read()
print(data)



#3 open file in UTF8
print ("----------")
print ("#3 open file in UTF8")
import io
f = io.open("C:\py\study\python_automate\\2_password_file\\file_with_password.txt", mode="r", encoding="utf-8")
print ("file object in python -> ", f)
print ("readed file with password -> ", f.read())


#4 access control. compareing md5
print ("----------")
print ("#4 access control. comparing md5")
import hashlib 
md5 = "3fc0a7acf087f549ac2b266baf94b8b1" 

password = open("C:\py\study\python_automate\\2_password_file\secretpass.txt","r")
read_password = password.read()
 
# encoding qwerty123 using encode() 
# then sending to md5() 
result = hashlib.md5(read_password.encode()) 
  
# printing the equivalent hexadecimal value. 
print("The hexadecimal equivalent of hash is : ", result.hexdigest()) 
print() 
print("md5 var type", md5, " ", type(md5))
print("result var type", result," ", type(result))
print(type(result.hexdigest())) 
print() 
if result.hexdigest() == md5: 
    print("Access allowed")
else:
    print("Access denied")
