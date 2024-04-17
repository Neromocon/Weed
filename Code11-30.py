user = {'name': "키메라", 'nickname': "수선화", 'coin': 5000, 'level': "중"}
car = {"차량번호": '한국 가 1234', "차종": '제네시스 G90', "색상": '검정', "배기량": 3800}

infoHobby = {'바둑': 10, '독서': 8, '영화감상': 7}
print("user =", user)
print("car =", car)
print("infoHobby", infoHobby)
print("%s님은 %s %s 을 운전하며 보유코인은 %d 입니다." % (user['name'], car['색상'], car['차종'], user['coin']))