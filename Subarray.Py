# https://leetcode.com/problems/shortest-unsorted-continuous-subarray/
# Given an integer array, you need to find one continuous subarray that if 
# you only sort this subarray in ascending order, then the whole array will be sorted in ascending order, too.
class Solution:
    def findUnsortedSubarray(self, nums: List[int]) -> int:

        sorted = nums.copy()
        sorted.sort()
        start = len(nums)
        end = 0
        
        for i in range (0,len(nums)):
            if sorted[i] != nums[i]:
                start = min(start,i)
                end = max(end, i)
                
        if end - start >= 0:
            return end - start +1
        else: 
            return 0
            

            