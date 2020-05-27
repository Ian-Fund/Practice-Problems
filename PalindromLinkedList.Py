# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

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
