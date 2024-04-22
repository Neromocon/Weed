line = "홍길동, 컴퓨터공학, 98, 65, 82, 92  "
line = line.rstrip()
print("line.rstrip()의 결과:", line)

line = line.split(',')
print("line.split(',')의 결과:", line)

scoreList = []
for i in range(2, len(line)) :
    score = int(line[i])
    scoreList.append(score)
print("line의 수치값 리스트:", scoreList)