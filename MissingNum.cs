// https://leetcode.com/problems/missing-number/submissions/
public class Solution {
    public int MissingNumber(int[] nums) {
        int sum = 0;
        foreach (int element in nums ){
            sum += element;
        }
        return Gauss((nums.Length))- sum;
    }
    
    private int Gauss(int length){
        return  (length * (length+1))/ 2;
    }
}