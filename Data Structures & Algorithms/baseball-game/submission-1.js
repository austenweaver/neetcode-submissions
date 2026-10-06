class Solution {
    /**
     * @param {string[]} operations
     * @return {number}
     */
    calPoints(operations) {

        let stack = [];


        for (let i = 0; i < operations.length; i++) {

            switch (operations[i]) {
                case '+':
                    stack.push(Number(stack[stack.length - 1] + stack[stack.length - 2]))
                    break;
                case 'D':
                    stack.push(Number(stack[stack.length - 1] * 2))
                    break;
                case 'C':
                    stack.pop();
                    break;
                default:
                    stack.push(Number(operations[i]))
            }

        }

        let score = 0;

        stack.forEach(i => {
            score += i;
        })

        return score

    }
}
