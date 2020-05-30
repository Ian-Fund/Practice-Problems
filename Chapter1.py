# problem 1.1
def uniqueChar (word):
    unique = {}
    for char in word:
        if char in unique.keys():
            return False
        unique.setdefault(char,0)
    return True
    
print("Unique")
print(uniqueChar("Ian"))
print(uniqueChar("Kari"))
print(uniqueChar("Lilly"))

# problem 1.2

def checkPermutation (one, two):
    if len(one) != len(two):
        return False
    oneDict = {}
    twoDict = {}
    for char in one:
        if char in oneDict.keys():
            oneDict[char] += 1
        else:
            oneDict[char] = 0
    for char in two:
        if char in twoDict.keys():
            twoDict[char] += 1
        else:
            twoDict[char] = 0
    for key in oneDict:
        if oneDict[key] != twoDict[key]:
            return False
    return True
print("Check Permutation")    
print(checkPermutation("hello","hello"))
print(checkPermutation("hello","heloo"))
print(checkPermutation("hello","heloo"))

def URLify(word):
    return word.replace(" ","%20")
    
print("URLify")
print(URLify("Mr John Smith"))
