public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = "";
        if (strs.Length == 0)
            return result;
        for(int i =0; i < strs[0].Length; i++){
            char cur = strs[0][i];
            for(int j = 1; j < strs.Length; j++ ){
                if (i > strs[j].Length-1 || strs[j][i] != cur)
                    return result;
            }
            result = result + cur;
        }
        return result;
    }
}
