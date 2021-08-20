from math import *

def isPrime(num):
    for i in range(2,int(sqrt(num))+1):
        if num%i == 0:
            return False
    return True

a = int(input("Enter a number: "))
if isPrime(a):
    print("given is prime number")
else:
    print("given is not a prime number")