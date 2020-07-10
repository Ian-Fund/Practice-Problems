public class Solution {
    public bool IsPalindrome(string s) {
       int front = 0;
       int back = s.Length-1;
        s = s.ToUpper();
       while(front <= back){
           while ( !char.IsLetterOrDigit(s[front])  ){
               front++;
               if ( front == s.Length)
                   return true;
           }
           while(!Char.IsLetterOrDigit(s[back]))
               back--;
           if(s[front] != s[back])
               return false;
           front++;
           back--;
           
       } 
      return true;     
    }
}
