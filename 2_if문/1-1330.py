str = input().split(' ')

A = int(str[0])
B = int(str[1])

if(A > B):
    print(">")
elif(A < B):
    print("<")
else:
    print("==")
