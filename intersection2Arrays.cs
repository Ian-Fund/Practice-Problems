// https://leetcode.com/problems/intersection-of-two-arrays-ii/submissions/
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        if (nums2.Length < nums1.Length)
            return Intersect(nums2,nums1);
        Dictionary<int, int> elements = new Dictionary<int,int>();
        foreach (int num in nums1){
            if (!elements.TryAdd(num,1))
                elements[num]++;
        }
        List<int> result = new List<int>();
        int count;
        int val;
        foreach (int num in nums2){
            if (elements.ContainsKey(num) && elements[num] > 0){
                result.Add(num);
                elements[num]--;
            }
            
        }
        return result.ToArray();
    }
}

public class Solution2 {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int i= 0;
        int j = 0;
        List<int> result = new List<int>();
        while (i < nums1.Length && j <nums2.Length){
            if (nums1[i] == nums2[j]){
                result.Add(nums2[j]);
                i++;
                j++;
            }
            else if (nums1[i] <nums2[j])
                i++;
            else
                j++;
        }
        return result.ToArray();
    }
}
