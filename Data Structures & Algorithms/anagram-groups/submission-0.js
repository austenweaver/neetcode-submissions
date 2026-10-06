class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {

        let map = new Map();

        for (let i = 0; i < strs.length; i++) {
            let sorted = strs[i].split('').sort().join('')
            
            if (map.has(sorted)) {
                map.get(sorted).push(strs[i]);
            }
            else {
                map.set(sorted, [strs[i]])
            }
        }

        let results = []
        for (let [key, value] of map) {
            results.push(value)
        }

        return results;

    }
}
