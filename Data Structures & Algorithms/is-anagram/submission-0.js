class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {

        if (s.length !== t.length) {
            return false;
        }

        let chars = new Map();


        for (let i = 0; i < s.length; i++) {
            // Check if letter is already in map, add if not
            if (!chars.has(s[i])) {
                chars.set(s[i], 0);
            }
            if (!chars.has(t[i])) {
                chars.set(t[i], 0);
            }

            // Increment for appearances in s, decrement for appearances in t (could do chars.set(s[i], 1) and chars.set(t[i], -1), but this keeps the code cleaner)
            chars.set(s[i], chars.get(s[i]) + 1);
            chars.set(t[i], chars.get(t[i]) - 1);
        }

        for (let char of chars) {
            if (char[1] !== 0) {
                return false
            }
        }
        return true;

    }
}
