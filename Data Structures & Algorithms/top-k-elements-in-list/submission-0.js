class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    topKFrequent(nums, k) {

        let buckets = new Array(nums.length + 1);

        let map = new Map();
        for (let i = 0; i < nums.length; i++) {

            if (map.has(nums[i])) {
                map.set(nums[i], map.get(nums[i]) + 1)
            }
            else {
                map.set(nums[i], 1)
            }
        }

        for (let [key, value] of map) {
            if (buckets[value]) {
                buckets[value].push(key)
            }
            else {
                buckets[value] = [key]
            }
        }

        const result = [];
        for (let i = buckets.length - 1; i >= 0 && result.length < k; i--) {
            if (buckets[i]) {
                for (const num of buckets[i]) {
                    result.push(num);
                    if (result.length === k) break;
                }
            }
        }

        return result

    }
}
