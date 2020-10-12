def dig_pow(n, p):
    sum = 0
    for i in str(n):
        r = (int(i) ** p)
        sum += r
        p += 1
    res = (int(sum / n))
    if sum % n == 0:
        return res
    else:
        return -1


# dig_pow(89, 1)     # 1)
# dig_pow(92, 1)     # -1)
# dig_pow(46288, 3)  # 51)

dig_pow(3263,1) #should equal -1
dig_pow(1,1) #should equal -1
dig_pow(9400,3) #should equal -1
