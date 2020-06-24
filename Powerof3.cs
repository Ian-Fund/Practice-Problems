public class Solution {
    public bool IsPowerOfThree(int n) {
        if (n == 1)
            return true;
        double num = (double) n;
        while (num > 3){
            num = num /3;
        }
        return (num == 3.0) ? true: false;
    }
}