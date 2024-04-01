def writeInfo(name, dept, major2="없음"):
    print("%s님 환영합니다!" % name)
    print("학과 : %s" % dept)
    print("부전공 : %s" % major2)

name = input("이름은? : ")
dept = input("학과는? : ")
answer = input("복수전공 이수 여부(Y/N) : ")
if answer == 'Y' or answer == 'y':
    major2 = input("복수 전공명 : ")
else :
    writeInfo(name, dept)
