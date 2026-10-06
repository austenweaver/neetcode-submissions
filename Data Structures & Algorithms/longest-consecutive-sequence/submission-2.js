class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    longestConsecutive(nums) {

        let set = new Set(nums);
        let currentLength = 0;
        let maxLength = 0;

        
        for (let num of set) {

            if (!set.has(num - 1)) {


                currentLength = 1
                while (set.has(num + currentLength)) {
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
