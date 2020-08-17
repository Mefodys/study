#while (1):
import time

# print ('-')
# time.sleep(1)
# print ('/')
# time.sleep(1)
# print ('|')
# time.sleep(1)
# print ('\\')
# time.sleep(1)

a=['-','/','|','\\']
while 1: 
    for i in range(len(a)):
        print(a[i], end="\r")
        time.sleep(0.1)
    
# animation = "|/-\\"
# idx = 0
# while (1):
#     a=animation[idx % len(animation)]
#     print(a, end="\r")
#     idx += 1
#     time.sleep(0.1)
