public class Solution {
    public bool IsHappy(int n) {
        int count = 0;
        while (count < 100){
            int len = n.ToString().Length;
            int result = 0;
            for (int i = 0; i < len; i++){
                //Console.WriteLine($"N % 10 is: {n%10}");
                result += ((n %10) *(n %10));
                n = n / 10;
            }
            //Console.WriteLine($"Result is: {result}");
            if (result == 1)
                return true;
            n = result;
            count++;
        }
        return false;
    }
}

public class Solution2 {
    public bool IsHappy(int n) {
        int fast = n;
        int slow = n;
        do {
            slow = addsDigits(slow);
            fast = addsDigits(fast);
            fast = addsDigits(fast);
            if (slow == 1 || fast == 1)
                return true;
        } while (fast != slow);
        return false;
    }
    private int addsDigits(int n){
        int len = n.ToString().Length;
        int result = 0;
        for (int i = 0; i < len; i++){
            result += ((n %10) *(n %10));
            n = n / 10;
        }
        return result;
        }
    }
