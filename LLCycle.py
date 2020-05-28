# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None
# https://leetcode.com/problems/linked-list-cycle/
# Given a linked list, determine if it has a cycle in it.


class Solution:
    def hasCycle(self, head: ListNode) -> bool:
        if head == None:
            return False
        visited= []
        cur = head
        while True:
            if cur == None:
                return False
            if cur in visited:
                return True
        
            visited.append(cur)
            cur = cur.next