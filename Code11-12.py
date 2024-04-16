score = [88, 54, 84, 75, 92]
sum = 0
n = len(score)
for i in range(0, n) :
    sum += score[i]
avg = sum / n
print("리스트 score 평균 : %6.2f" % avg)