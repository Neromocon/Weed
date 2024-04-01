def writeFactorial(n):
    fact = 1
    for i in range(1, n+1):
        fact = fact * i
    print("%d! = %d" % (n, fact))

n = int(input("정수 : "))
writeFactorial(n)
