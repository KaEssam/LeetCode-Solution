public class Solution {
    public int[] GetConcatenation(int[] nums) {

        int[] ans = new int[2 * nums.Length];

        for( int i=0; i<nums.Length; i++)
            ans[i] = ans[i+nums.Length] = nums[i];
            return ans;
        
        
    }
}