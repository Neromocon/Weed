# class1 = [
#     [88, 75, 96, 74, 82],
#     [72, 82, 63, 88, 76],
#     [92, 84, 82, 96, 76]
# ]
# classSum = 0; i=0; numsubj=0
# for stu in class1:  #stu는 3번 반복됨. class1리스트의 원소 갯수
#     sum=0
#     for subj in stu: # subj는 5번 반복됨. stu는 class1리스트의 원소 리스트
#         sum = sum+subj
#     avg = sum / len(stu)
#     print("%d번 학생 : 총점=%d, 평균=%6.2f" % (i, sum, avg))
#     i = i + 1
#     numsubj += len(stu)
#     classSum = classSum + sum
# avgClass = classSum / (numsubj)
# print("전체 평균 = %6.2f" % (avgClass))

class1 = [
    [88, 75, 96, 74, 82],
    [72, 82, 63, 88, 76],
    [92, 84, 82, 96, 76]
]
classAvg = 0; i=0; numsubj=0
for stu in class1:  #stu는 3번 반복됨. class1리스트의 원소 갯수
    sum=0
    for subj in stu: # subj는 5번 반복됨. stu는 class1리스트의 원소 리스트로 취급??
        sum = sum+subj
    avg = sum / len(stu)
    print("%d번 학생 : 총점=%d, 평균=%6.2f" % (i, sum, avg))
    i = i + 1
    numsubj += len(stu)
    classAvg = classAvg + avg
avgClass = classAvg / len(class1)
print("전체 평균 = %6.2f" % (avgClass))