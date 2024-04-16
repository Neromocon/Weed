score = [88, 54, 76, 65, 84, 76, 92, 100, 82, 85]
min = max = score[0]
n = len(score)
for i in range(1, n) :
    if min > score[i] :
        min = score[i]
        continue
    elif max < score[i] :
        max = score[i]
print("최저 점수 : %d \n최고 점수 :" % min, max)