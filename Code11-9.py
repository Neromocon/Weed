nickname = []
for i in range(3) :
    byname = input("닉네임 입력: ")
    nickname.append(byname)
print(nickname, "리스트 크기 :", len(nickname))

byname = input("닉네임 2번째 추가 입력: ")
nickname.insert(2, byname)
print("2번째 추가 결과", nickname, "리스트 크기 :", len(nickname))
nickname.sort(); print("정렬 결과: ", nickname)
nickname.reverse(); print("역정렬 결과:", nickname)