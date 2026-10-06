class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s) {



        s = s.toLowerCase();

        let punctuation = [',', '\'', '.', '?', ' ', ':', ';']
        for (let p of punctuation) {
        s = s.replaceAll(p, "");
        }
        

        console.log(s)
        for (let i = 0; i < (s.length / 2); i++) {
            if (s[i] !== s[s.length - i - 1]) {
                return false;
            }
        }
        return true;
    }
}
