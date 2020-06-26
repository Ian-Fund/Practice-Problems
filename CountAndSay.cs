public class Solution {
    public string CountAndSay(int n) {
        return countDigits(n-1);
    }
    private string countDigits(int n){
        if (n == 0)
            return "1";
        string x = countDigits(n-1);
        string result = "";
        char lastKnown = x[0];
        int counter = 1;
        for(int i =1; i < x.Length; i++ ){
            if (x[i] == lastKnown)
                counter++;
            else{
                result += counter.ToString();
                result += lastKnown;
                lastKnown = x[i];
                counter = 1;
            }
        }
        result += counter.ToString();
        result += lastKnown;
        return result;
    }
}
