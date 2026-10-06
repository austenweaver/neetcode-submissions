class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {

        let seen = new Set(nums);

        return seen.size !== nums.length;

    }
}
