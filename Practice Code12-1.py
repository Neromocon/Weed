name, eng, math, total, avg, grade, ranking = [], [], [], [], [], [], []
second = 0
engTotal = mathTotal = avgTotal = 0
engTop = mathTop = engBottom = mathBottom = 0  # 최고, 최저 득점
engTopName = mathTopName = engBottomName = mathBottomName = 0

# 학생 수를 class1.txt 파일에서 읽어오기
infile = open("class1.txt", "r", encoding="utf-8")
n = int(infile.readline().rstrip('\n'))

# 학생 데이터를 읽어오기
for i in range(0, n) :  # 0부터 n까지의 범위에서 반복문 실행. 이때 n은 csv파일에서 첫번째
                        #  줄에서 읽어온 학생 수를 나타냄
    stu = infile.readline().rstrip('\n').split(',')
    # 파일에서 한 줄을 읽어옴. readline()은 파일에서 한 줄을 읽어옴.
    # rstrip('\n')을 사용해서 줄 바꿈 문자를 저거함.
    # split(',')을 사용하여 쉼표를 기준으로 문자열을 분리하여 리스트로 만듬.
    # 위의 처리과정을 진행 시 stu 리스트에 학생의 이름, 영어, 수학이 순서대로 들어감.
    name.append(stu[0]) # stu리스트의 첫 번째 요소로 이름이 들어감
    eng.append(int(stu[1])) #이하 동일
    math.append(int(stu[2])) # 이하 동일
infile.close()

# -------- 등급 계산
def getGrade(score) :
    
    if score >= 90 : return('A')
    elif score >= 80 : return('B')
    elif score >= 70 : return('C')
    elif score >= 60 : return('D')
    else : return('F')
# -------타이틀
def printTitle() :
    print("-"*53)
    print(" 이 름\t\t영어\t수학\t총점\t평균\t학점")
    print("-"*53)
# -------
def printRecord(name, eng, math, total, avg, grade) :
    print(" %s\t\t%3d\t%3d\t%3d\t%.2f\t%2c" % (name, eng, math, total, avg, grade))
    print("-"*53)

# class.csv 파일 읽기와 결과 저장
f1 = open("class1.csv", "r", encoding="utf-8")
f2 = open("class1.out", "w", encoding="utf-8")
f2.writelines("[성적 처리 결과]\n")

#최고/처저 득점 구하기.
for i in range(1, n):
    if eng > engTop: eng = engTop 
    elif eng < engBottom : eng = engBottom


# 첫 번째 줄은 이미 읽었으므로 건너뜀
f1.readline()


for line in f1 :
    stu = (line.rstrip()).split(',')
    total = int(stu[1]) + int(stu[2])  # 영어와 수학 점수 합산
    avg = total / 2 # 평균 계산
    grade = getGrade(avg) #등급 계산
    printRecord(stu[0], int(stu[1]), int(stu[2]), total, avg, grade)  #기록 출력
    stuResult = "이름: %s  총점: %3d  평균: %6.2f  학점: %s\n" % (stu[0], total, avg, grade)
    f2.write(stuResult)  #결과 파일에 쓰기
f1.close()
f2.close()