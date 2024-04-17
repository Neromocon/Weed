f1 = open("./memo.txt", "w", encoding="utf-8")
str1 = "[2022년 3월 7일 월요일]\n"
str1 = str1 + "파이썬 공부를 시작함\n\n"
f1.write(str1)
f1.close()
f1 = open("./memo.txt", "a", encoding="utf-8")
str1 = "[2022년 3월 14일 월요일]\n"
str1 = str1 + "교재 1~2장을 공부함"
f1.write(str1)
f1.close()