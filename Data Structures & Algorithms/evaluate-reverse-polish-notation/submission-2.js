class Solution {
    /**
     * @param {string[]} tokens
     * @return {number}
     */
    evalRPN(tokens) {

        let stack = []
        let operators = new Set(['+', '-', '*', '/'])

        for (let i = 0; i < tokens.length; i++) {

            if (operators.has(tokens[i])) {

                let val2 = parseInt(stack.pop());
                let val1 = parseInt(stack.pop());

                switch (tokens[i]) {
                    case '+':
                        stack.push(val1 + val2)
                        break;
                    case '-':
                        stack.push(val1 - val2)
                        break;
                    case '*':
                        stack.push(val1 * val2)
                        break;
                    case '/':
                        stack.push(Math.trunc(val1 / val2))
            }

            }
            else {
                stack.push(tokens[i])
            }
        }

        return stack.pop();
    }
}
