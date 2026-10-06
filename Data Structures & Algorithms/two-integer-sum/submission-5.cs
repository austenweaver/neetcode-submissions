public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();


        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey(target - nums[i])) {
                return [dict[target - nums[i]], i];
            }
            dict.Add(nums[i], i);
        }

        return [0,0];
    }
}
