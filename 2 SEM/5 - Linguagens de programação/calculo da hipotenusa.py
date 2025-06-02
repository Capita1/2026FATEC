import math
cat1 = [3, 10, 2.4]
cat2 = [4, 10, 5.6]
hip = [5.0, 14.142, 6.09]

for x in range(len(hip)):
    hip = (cat1[x]**2+cat2[x]**2)
    print (math.sqrt(hip))
