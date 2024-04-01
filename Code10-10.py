def localTrade4():
    global price  # global : 전역 변수를 함수 안에서 사용할 때
                  #해당 값을 변경해야 할 때 변경이 가능하도록 만들어준다.
    salePrice = price *1.2
    print(price, salePrice)
    price=2000
    salePrice = price * 1.2
    print(price, salePrice)

price = 1000
localTrade4()
print(price)
