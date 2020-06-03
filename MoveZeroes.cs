// https://leetcode.com/problems/move-zeroes/submissions/

public class Solution {
    public void MoveZeroes(int[] nums) {
        int zero = 0;
        int nonZ = 0;
        int temp;
        
        while (nonZ < nums.Length){
            if (nums[nonZ] == 0) nonZ++;
            else{
                temp = nums[zero];
                nums[zero] = nums[nonZ];
                nums[nonZ] = temp;
                zero++;
                nonZ++;
                
            }
        }
    }
}
