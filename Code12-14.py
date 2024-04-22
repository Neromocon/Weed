f1 = open("data4.csv", "r", encoding="utf-8") ; f2 = open("data4.out", "w", encoding="utf-8")
f2.writelines("[성적 처리 결과]\n")
for line in f1 :
    stu = (line.rstrip()).split(",")
    total = 0
    for i in range(1, len(stu)) :
        total += int(stu[i])
    avg = total / (len(stu)-1)
    stuResult = "이름: %s  총점: %3d  평균: %6.2f\n" % (stu[0], total, avg)
    f2.write(stuResult)
f2.close() ; f2.close()