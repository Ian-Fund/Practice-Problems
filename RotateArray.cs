// https://leetcode.com/problems/rotate-array/submissions/
// Solution 1: Time: O(n) Space: O(1)
public class Solution {
    public void Rotate(int[] nums, int k) {
        int length = nums.Length;
        k %= length;
        reverse(nums,0,length-1);
        reverse(nums,0,k-1);
        reverse(nums,k,length-1);
        
    }
    private void reverse(int[] nums, int start, int end){
        while(start< end){
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}

public class Solution2 {
    public void Rotate(int[] nums, int k) {
        int length = nums.Length;
        int[] rotated= new int[nums.Length];
        for(int i =0; i < nums.Length; i++){
            rotated[(k+i)%length] = nums[i];
        }
        for( int i =0; i <length; i++){
            nums[i] = rotated[i];
        }
    }
}
