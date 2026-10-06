class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    longestConsecutive(nums) {

        let set = new Set(nums);
        let currentLength = 0;
        let maxLength = 0;

        for (let i = 0; i < nums.length; i++) {

            set.add(nums[i]);

        }

        
        for (let i = 0; i < nums.length; i++) {

            if (!set.has(nums[i] - 1)) {


                currentLength = 1
                while (set.has(nums[i] + currentLength)) {
                    currentLength++;
                }
                if (currentLength > maxLength) {
                    maxLength = currentLength;
                }


            }

        }

        return maxLength;

    }
}
