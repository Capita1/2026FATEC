tempo = 7480
h = tempo//3600
m = (tempo%3600)//60
s = (tempo%3600)%60
print(f"{h}:{m}:{s}")
