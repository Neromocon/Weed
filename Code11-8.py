score = []
n = int(input("학생 수: "))
for i in range(0, n) :
    jumsu = int(input("[%d] 시험 성적: " % i))
    score.append(jumsu)
print("score=", score)