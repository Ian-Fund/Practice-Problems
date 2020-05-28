# https://leetcode.com/problems/two-sum/
# Given an array of integers, return indices of the two numbers such that they add up to a specific target.

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        compliment_map = dict()
        
        for i in range(len(nums)):
            compliment  = target - nums[i]

            if nums[i] in compliment_map.keys():
                return [compliment_map[nums[i]],i]
            compliment_map.setdefault(compliment,i)
            