public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
        if (map.ContainsKey(nums[i]))
            return new int[] { i, map[nums[i]] };
        map[target - nums[i]] = i;
        }

        return new int[] { -1, -1 };
        }
}