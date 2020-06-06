// https://leetcode.com/problems/excel-sheet-column-number/submissions/
public class Solution {
    public int TitleToNumber(string s) {
        double result = 0;
        for (int i =0; i <s.Length; i++){
            result += Math.Pow((double)26,(double)(s.Length -1-i)) * ((int)s[i]-64) ;
        }
        return (int)result;
    }
}
