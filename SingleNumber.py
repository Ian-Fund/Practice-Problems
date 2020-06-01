#https://leetcode.com/problems/single-number/submissions/
# Given a non-empty array of integers, every element appears twice except for one. Find that single one.
class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        temp = 0
        for i in nums:
            temp ^= i
            
        return temp
        
    def singleNumber2(self, nums: List[int]) -> int:
        result = {}
        for i in  nums:
            if (i)  in result.keys():
                result[(i)] = result[(i)] +1 
            else:
                result[(i)] = 1
        for key in result:
            if result[key] == 1:
                return key