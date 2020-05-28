# https://leetcode.com/problems/house-robber/
# You are a professional robber planning to rob houses along a street. Each house has a certain amount of money 
# stashed, the only  constraint stopping you from robbing each of them is that adjacent houses have security system 
# connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
class Solution:
    def rob(self, nums: List[int]) -> int:
        if (len(nums) == 0 or nums == None):
            return 0
        
        if (len(nums)== 1):
            return nums[0]
        
        running_Total  = []
        running_Total.append(nums[0])
        running_Total.append(max(nums[0],nums[1]))
        
        for i in range(2,len(nums)):
            running_Total.append(max(running_Total[i-1],running_Total[i-2]+nums[i]))
            
        return max(running_Total)