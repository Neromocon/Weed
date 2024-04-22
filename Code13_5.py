def isPrime(n) :
    for i in range(2, n) :
        if (n % i) == 0 : return False
    return True

if __name__ == "__main__" :
    n = int(input("자연수 입력: "))
    if isPrime(n) : print("%d는 소수임" % n)
    else :
        print("%d는 소수 아님" % n)