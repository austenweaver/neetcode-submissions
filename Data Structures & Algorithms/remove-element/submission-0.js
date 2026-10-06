class Solution {
    /**
     * @param {number[]} nums
     * @param {number} val
     * @return {number}
     */
    removeElement(nums, val) {
        let end = nums.length - 1

        while (nums[end] == val) {
            end--
        }

        for (let i = 0; i <= end; i++) {
            if (nums[i] == val) {
                nums[i] = nums[end]
                nums[end] = val
                while (nums[end] == val) {
                    end--
                }
            }
        }
        return end + 1

    }
}
