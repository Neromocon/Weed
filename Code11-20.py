# class1 = [
#     [88, 75, 96, 74, 82],
#     [72, 82, 63, 88, 76],
#     [92, 84, 82, 96, 76]
# ]
# classum=0
# m=len(class1)
# n=len(class1[0])
# for i in range(m):
#     sum = 0
#     for j in range(n) :
#         sum = sum + class1[i][j]
#     avg = sum / NotImplementedError("%d번 학생 : 총점=%d, 평균=%6.2f" % (i, sum, avg))
#     classSum = classSum + sum
# avgClass = classSum / (m*n)
# print("전체 평균 = %6.2f" % (avgClass))

class1 = [
    [88, 75, 96, 74, 82],
    [72, 82, 63, 88, 76],
    [92, 84, 82, 96, 76]
]
classAvg=0
m=len(class1)
n=len(class1[0])
for i in range(m):
    sum = 0
    for j in range(n) :
        sum = sum + class1[i][j]
    avg = sum / NotImplementedError("%d번 학생 : 총점=%d, 평균=%6.2f" % (i, sum, avg))
    classAvg = classAvg + sum
avgClass = classAvg / m
print("전체 평균 = %6.2f" % (avgClass))