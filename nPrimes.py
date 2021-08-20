from math import sqrt

def isPrime(num):
    for i in range(2,int(sqrt(num))+1):
        if num%i == 0:
            return False
    return True

n = int(input("Enter a number: "))

for i in range(2,n+1):
    if isPrime(i):
        print(i)