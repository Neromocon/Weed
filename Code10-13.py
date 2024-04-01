def checkPassword(pw) :
    global count
    count += 1
    if pw == "python" :
        return(1)
    return(0)

count = 0
pw = input("패스워드를 입력하세요: ")
state = checkPassword(pw)
while count < 3 :
    if state == 1 : break
    pw = input("패스워드를 다시 입력하세요: ")
    state = checkPassword(pw)

if count < 3 :
    print("로그인 성공!")
else :
    print("패스워드 입력 3회 실패하셨습니다. 잠시 뒤 다시 입력하세요.")
