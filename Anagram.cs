// https://leetcode.com/problems/valid-anagram/submissions/
public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();
        
        if (s.Length != t.Length) return false;
        for (int i = 0; i < s.Length; i++){
            if (!sDict.TryAdd(s[i],1) ) sDict[s[i]] ++;
            if (!tDict.TryAdd(t[i],1) ) tDict[t[i]] ++;
        }
        foreach(KeyValuePair<char,int> entry in sDict){
            if (!tDict.ContainsKey(entry.Key)) return false;
            if (entry.Value != tDict[entry.Key]) return false;
        }
        return true;
    }
}
