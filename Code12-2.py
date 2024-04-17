f1 = open("data1.txt", "r")
print("="*20)
txt = f1.read(1)
while txt != "" :
    print(txt, end = "")
    txt = f1.read(1)

print("\n" + "="*20)
f1.close()