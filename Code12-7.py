f1 = open("file.txt", "r")
txt = f1.readline()
print(txt)
f1.close()

f2 = open("file.txt", "r")
txt = f2.readline()
print(txt)
txt = f2.readline()
print(txt)
f2.close()

txt = f2.read()