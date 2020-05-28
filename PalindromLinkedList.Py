# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
# Given a singly linked list, determine if it is a palindrome.
# TWo solutions. 1 is O(n) in O(n) space. 2 is 0(n) in O(1) space
class Solution:
    def isPalindrome(self, head: ListNode) -> bool:
        if head == None or  head.next == None:
            return True
        nums = []
        current = head
        while current != None:
            nums.append(current.val)
            current = current.next
            
        for i in range (0, len(nums)):
            if nums[i] != nums[len(nums)-(i+1)]:
                return False
        return True

    def isPalindromeInPlace(self, head: ListNode) -> bool:
        
        if head == None or  head.next == None:
            return True
        length = 0
        current = head
        while current != None: 
            length += 1
            current = current.next
        middle = head    
        # Even Case
        if length % 2 == 0:
            for i in range (0,length //2):
                middle = middle.next
        # Odd Case
        else:
            for i in range (0,(length //2)+1 ):
                middle = middle.next
        # Set up Three pointers for reversing second half of list        
        previous = None
        current = middle
        nextN = middle.next 
        
        # Reverse second half of list in place
        while current != None:
            nextN = current.next
            current.next = previous
            previous = current
            current = nextN
        # Check for palindrome    
        while previous != None:
            if head.val != previous.val:
                return False
            head = head.next
            previous = previous.next
        return True