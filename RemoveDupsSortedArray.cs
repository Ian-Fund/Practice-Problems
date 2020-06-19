public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0 )
            return 0;
        int p1 = 0; 
        for (int p2 = 1; p2 < nums.Length; p2++){
            if (nums[p1] != nums[p2]){
                p1++;
                nums[p1] = nums[p2];
            }
        }  
        return p1+1;
    }
}