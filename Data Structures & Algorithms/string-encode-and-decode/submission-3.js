class Solution {
    /**
     * @param {string[]} strs
     * @returns {string}
     */
    encode(strs) {

        let output = ""

        for (let str of strs) {
            output += str.length
            output += "#"
            output += str
        }

        return output
    }

    /**
     * @param {string} str
     * @returns {string[]}
     */
    decode(str) {

        let output = [];

        for (let i = 0; i < str.length; i++) {
            
            let lengthStr = str.substring(i, str.indexOf('#', i))
            i += lengthStr.length + 1;
            output.push(str.substring(i, i + parseInt(lengthStr)))
            i += parseInt(lengthStr) - 1

        }

        return output
    }
}
