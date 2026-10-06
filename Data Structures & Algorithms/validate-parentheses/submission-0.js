class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isValid(s) {

        if (s.length % 2 !== 0) {
            return false;
        }

        let stack = new Array();

        let openers = new Set(['(', '{', '[']);

        let map = {']':'[', '}':'{', ')':'(' }

        for (let i = 0; i < s.length; i++) {
            if (openers.has(s[i])) {
                stack.push(s[i])
            }
            else {
                if (stack[stack.length - 1] === map[s[i]]) {
                    stack.pop();
                }
                else {
                    return false;
                }
            }
        }


        return stack.length === 0;


    }
}
