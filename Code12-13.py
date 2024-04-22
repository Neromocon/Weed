f1 = open("data3.dat", "r", encoding="utf-8")
print("[자료 파일 입력 결과]\n")

for line in f1 :
    substr = (line.rstrip()).split("  ")
    data = []
    for i in range(0, len(substr)) :
        data.append(substr[i])
    print(data)
f1.close()