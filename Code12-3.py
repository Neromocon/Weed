f2 = open("./result1.txt", "w")
txt = input("메세지를 남기세요. \n")
for i in range(3) :
    f2.write(txt)
    f2.write("\n")
    txt = input()
f2.close()