public class Solution {
    public int LengthOfLastWord(string s) {
        int n = s.Length;
        int result = 0;
        while (n > 0) {
            n--;
            if (s[n] != ' ') {
                result++;
            }
            else if (result > 0) {
                return result;
            }
        }   
        return result;
    }
}