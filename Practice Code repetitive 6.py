# 1~100까지의 수 중에서 홀수와 홀수의 합을 실행 결과와 같이 출력하는 프로그램을 작성하시오.
# 1+3+5+...+99

sum = 0
for i in range(1,100,2):    #range(1,100,2) 에서 2는 1부터 100까지 2씩 건너뛴다는 뜻.
    sum += i
    print(i,end=" ")
print(" = ", sum)
