c class Solution {
	    public bool ContainsDuplicate(int[] nums) {
		            if (nums.Length == 0 || nums.Length ==1) return false;
			            Dictionary<int,int> dups = new Dictionary<int, int>();
				            
				            for (int i = 0; i < nums.Length; i++){
						                if (dups.ContainsKey(nums[i])) return true;
								            else dups[nums[i]] = 1;
									            }
					            return false;
						        }
}
