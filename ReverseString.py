# https://leetcode.com/problems/reverse-string/
# Write a function that reverses a string. 
class Solution:
    def reverseString(self, s: List[str]) -> None:
        """
        Do not return anything, modify s in-place instead.
        """
        for i in range(len(s)//2):
            front = s[i]
            back = s[len(s)-(i+1)]
            
            s[i] = back
            s[len(s)-(i+1)] = front
            