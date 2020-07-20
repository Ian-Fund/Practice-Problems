public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        Dictionary<int,int> compliment = new Dictionary<int,int>();
        for(int i = 0; i <nums.Length; i++){
            int value = target - nums[i];
            compliment.TryAdd(value,i);
        }
        for (int i= 0; i < nums.Length; i++){
            if (compliment.ContainsKey(nums[i])){
                if (i == compliment[nums[i]])
                    continue;
                result[0] = i;
                result[1] = compliment[nums[i]];
                return result;
            }
                
        }
        return result;
    }
}
