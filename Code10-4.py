def computeFactorial(n):
    fact = 1
    for i in range(1, n+1):
        fact = fact * i
    return fact

n = int(input("정수 : "))
print("%d! = %d" % (n, computeFactorial(n)))
