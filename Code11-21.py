flowers = ['장미', '튤립', '수선화', '카네이션', '국화']
favouriteFlower = input("구매할 꽃을 알려주세요 : ")
if favouriteFlower in flowers :
    print("감사합니다. 바로 준비하겠습니다.")
    print("조금만 기다려 주세요.")
else:
    print("죄송합니다. 요청하신 꽃은 없습니다.")
    print("빠른 시일 내에 준비하겠습니다.")