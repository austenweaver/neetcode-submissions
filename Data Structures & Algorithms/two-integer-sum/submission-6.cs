public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> dict = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey(target - nums[i])) {
                return [dict[target - nums[i]], i];
            }
            else {
                dict[nums[i]] = i;
            }
        }
        return [-1,-1];
    }
}
