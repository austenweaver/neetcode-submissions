class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    productExceptSelf(nums) {


        let prefixes = new Array(nums.length);
        let suffixes = new Array(nums.length);

        for (let i = 0; i < nums.length; i++) {
            
            prefixes[i] = i === 0 ? 1 : prefixes[i - 1] * nums[i - 1];
            suffixes[nums.length -  i - 1] = i === 0 ? 1 : suffixes[nums.length - i] * nums[nums.length - i]; 

        }

        let output = new Array(nums.length);

        for (let i = 0; i < nums.length; i++) {

            output[i] = prefixes[i] * suffixes[i]
        }

        return output;

    }
}
