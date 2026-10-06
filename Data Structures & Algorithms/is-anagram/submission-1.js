class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {

        if (s.length != t.length) {
            return false;
        }

        let w1 = new Map();
        let w2 = new Map();

        for (let i = 0; i < s.length; i++) {
            w1.set(s[i], 1 + (w1.get(s[i]) ? w1.get(s[i]) : 0))
            w2.set(t[i], 1 + (w2.get(t[i]) ? w2.get(t[i]) : 0))
        }

        for (let [key, value] of w1) {
            if (w2.get(key) !== value) {
                return false;
            }

        }

        return true;




    }
}
