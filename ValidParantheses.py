# https://leetcode.com/problems/valid-parentheses/
# Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
# Second solution implements a map and cleans up code from solution 1
class Solution:
    def isValid(self, s: str) -> bool:
        if len(s) == 0:
            return True
        
        if len(s) == 1:
            return False
        stack = ["Z"]
        for i in range (0,len(s)):
            if s[i] == ')' and stack[len(stack)-1] == '(':
                stack.pop(len(stack) - 1)
                continue
            #    s.pop(i)
            if s[i] == '}' and stack[len(stack)-1] == '{':
                stack.pop(len(stack) - 1)
              #  s.pop(i)
                continue
            if s[i] == ']' and stack[len(stack)-1] == '[':
                stack.pop(len(stack) - 1)
                continue
              #  s.pop(i)
            else:
                stack.append(s[i])
        if stack[len(stack)-1] == "Z":
            return True
        return False
            
            
      def isValid2(self, s: str) -> bool:
        if len(s) == 0:
            return True
        symbols = {")":"(","}":"{","]":"[" }
        stack = []
        for char in s:
            if char in symbols:
                if len(stack) == 0:
                    return False
                if stack.pop() != symbols[char]:
                    return False
            else:
                stack.append(char)
        if len(stack) == 0:
            return True
        return False
            