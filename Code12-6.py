f1 = open("file.txt", "r")
txt = f1.read()
print("read() 반환값:", txt)
f1.close()

f1 = open("file.txt", "r")
txt = f1.read(3)
print("read(3) 반환값:", txt)
f1.close()

f1 = open("file.txt", "r")
txt = f1.readline()
print("readline() 반환값:", txt)
f1.close()

f1 = open("file.txt", "r")
txt = f1.readlines()
print("readlines() 반환값:", txt)
f1.close()

print("\nfile.txt 파일 내용 출력")
for element in txt :
    print(element, end = " ")