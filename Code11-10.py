class1 = [70, 80, 60, 80, 90]
class2 = [85, 95, 80, 65, 70]
print("class1 = ", class1)
print("class2 = ", class2)

class1.extend(class2)
# 리스트명.extend(i) 현재 리스트에 리스트i를 합침
print("'class1.extend(class2)' 실행 직후 class1 = ", class1)
n = class1.count(80)
print("class1에서 80의 개수 :", n)
class1.remove(80)
# 리스트명.remove(i) 가장 앞쪽의 i를 삭제함
print("'class1.remove(80)' 실행 직후 class1 ", class1)
high = max(class1)
low = min(class1)
print("max =", high, "min =", low)
class3 = sorted(class1)
# sorted(i) 정렬된 새로운 리스트를 생성, 반환함.
print("'class3 = sorted(class1)' 실행 직후 class1=", class1)
print("'class3 = sorted(class1)' 실행 직후 class3=", class3)