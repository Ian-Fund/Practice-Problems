public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        Dictionary<int,int> compliment = new Dictionary<int,int>();
        for(int i = 0; i <nums.Length; i++){
            int value = target - nums[i];
            if (compliment.ContainsKey(nums[i])){
                result[0] = i;
                result[1] = compliment[nums[i]];
                return result;
            }
            compliment.TryAdd(value,i);
        }
   
        return result;
    }
}
