public class Solution {
    public bool IsAnagram(string s, string t) {

        // convert word to char array
        char[] ss = s.ToCharArray();
        char[] tt = t.ToCharArray();

        // sort array
        Array.Sort(ss);
        Array.Sort(tt);


        // check if char of each array equal
        return new string(ss) == new string(tt);
    }
}