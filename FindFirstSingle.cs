// https://leetcode.com/problems/first-unique-character-in-a-string/solution/
public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> counts = new Dictionary<char,int>();
        
        for (int i = 0; i <s.Length; i++){
            if (!counts.TryAdd(s[i],1))
                counts[s[i]] ++;   
        }
        for (int i = 0; i < s.Length; i++){
            if (counts[s[i]] == 1) return i;
        }
        return -1;
    }
}
