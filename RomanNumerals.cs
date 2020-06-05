// https://leetcode.com/problems/roman-to-integer/
public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> romans = new Dictionary<char,int>();
        if (s.Length == 0) return 0;
        romans['I']  = 1;
        romans['V']  = 5;
        romans['X']  = 10;
        romans['L']  = 50;
        romans['C']  = 100;
        romans['D']  = 500;
        romans['M']  = 1000;
        
        int total = 0;
        for (int i = 0; i < s.Length ; i++){
            if (i < s.Length -1 && romans[s[i]]< romans[s[i+1]]){
                total += (romans[s[i+1]]-romans[s[i]]);
                i++;
                continue;
            }
            total += romans[s[i]];
        }
        return total;
    }
}