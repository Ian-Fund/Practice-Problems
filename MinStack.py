# https://leetcode.com/problems/min-stack/
# Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
# MinStack2 implements stack differently for increased performance.

class MinStack:

    def __init__(self):
        self.stack = []
        self.min_val = float("inf")
        self.min_stack = [self.min_val] 
        
    def push(self, x: int) -> None:
        if x <= self.min_val:
            self.min_val = x
            self.min_stack.insert(0,self.min_val)
        self.stack.insert(0,x)

    def pop(self) -> None:
        if self.top() == self.min_val:
            self.min_stack.remove(self.min_val)
            self.min_val = self.min_stack[0]
        self.stack.remove(self.top())

    def top(self) -> int:
        return self.stack[0]

    def getMin(self) -> int:
        return(self.min_val)
        
        
class MinStack2:

    def __init__(self):
        self.stack = []
        self.min_val = float("inf")
        self.min_stack = [self.min_val] 
        
    def push(self, x: int) -> None:
        if x <= self.min_val:
            self.min_val = x
            self.min_stack.append(self.min_val)
        self.stack.append(x)

    def pop(self) -> None:
        if self.top() == self.min_val:
            self.min_stack.remove(self.min_val)
            self.min_val = self.min_stack[-1]
        self.stack.pop(-1)

    def top(self) -> int:
        return self.stack[-1]

    def getMin(self) -> int:
        return(self.min_val)
        
