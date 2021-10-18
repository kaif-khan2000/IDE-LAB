from math import sqrt
def isPrime(num):
    for i in range(2,int(sqrt(num))+1):
        if num%i==0:
            return False
    return True

n1 = int(input("Enter a number:"))
n2 = int(input("Enter a number:"))
if isPrime(n1) == True and isPrime(n2) == True:
    print("Prime")
else:
    print("not prime")