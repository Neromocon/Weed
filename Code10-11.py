def callFunction():
    global count
    print("%d=번째 호출" % count)
    if count < 2:
        count += 1
    else :
        count = 0
    return(count)

count = 0
for i in range(0, 10) :
    callFunction()
