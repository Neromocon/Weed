def getGrade(score) :
    
    if score >= 90 : return('A')
    elif score >= 80 : return('B')
    elif score >= 70 : return('C')
    elif score >= 60 : return('D')
    else : return('F')

def printTitle() :
    outfile.write("-"*53)
    outfile.write("\n")
    outfile.write(" 이 름\t\t영어\t수학\t총점\t평균\t학점")
    outfile.write("\n")
    outfile.write("-"*53)

def printRecord(name, subj1, subj2, mean, level) :
    outfile.write("\n")
    outfile.write(" %s\t\t%3d\t%3d\t%3d\t%.2f\t%2c" % (name, subj1, subj2, subj1+subj2, mean, level))
    outfile.write("\n")
    outfile.write("-"*53)


#======
second = 0
name, eng, math, total, avg, grade, ranking = [], [], [], [], [], [], []
engTotal = mathTotal = avgTotal = 0
infile = open("class1.txt", "r", encoding="utf-8")
outfile = open("result.out", "w", encoding="utf-8")
n = int(infile.readline().rstrip('\n'))

#n = int(input("학생 수 입력 : "))

# n명 학생 이름, 영어, 수학 성적 입력 및 리스트 name ,eng, math 구성
for i in range(0, n) :
    print("\n%d번째 학생 자료 입력" % i)
    name.append(input("이름: "))
    eng.append(int(input("영어 성적: ")))
    math.append(int(input("수학 성적: ")))

# 총점, 평균, 학점 계산 및 total, avg, grade 리스트 구성
for i in range(0, n) :
    total.append(eng[i] + math[i])
    avg.append(total[i] / 2)
    grade.append(getGrade(avg[i]))

for i in range(0, n) :
    engTotal += eng[i]
    mathTotal += math[i]
    avgTotal += avg[i]


name, eng, math, total, avg, grade, ranking= [], [], [], [], [], [], []



# n명 학생 이름, 영어 성적, 수학 성적 입력 및 리스트 name, eng, math 구성
for i in  range(0, n) :
    stu = infile.readline().rstrip('\n').split(',')
    name.append(stu[0])
    for j in range(1, len(stu)) :
        eng.append(int(stu[j]))
        math.append(int(stu[j]))
infile.close() 

# 전체 성적표 출력
printTitle()
# for i in range(0, n) :
#     printRecord(name[i], eng[i], math[i], avg[i], grade[i])
for i in range(0, n) :
     printRecord(stu[i][0], stu[i][1], stu[i][2], stu[i][4], stu[i][5])



# 최고득점자 조사 및 출력
max = 0
for i in range(1, n) :
    if total[max] < total[i] : max = i
    print("\n학급 학생수 : %3d" % n)
    print("\n학급 전체 평균 : %6.2f" % (avgTotal / n))
    print("\n최고득점자 : %3d" % (name[max]))
    print("\n최저득점자 : %3d" % (name[min]))