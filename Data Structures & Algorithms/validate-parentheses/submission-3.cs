public class Solution {
    public bool IsValid(string s) {

        if (s.Length % 2 != 0) {
            return false;
        }
        
        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> map = new Dictionary<char, char>{{'[', ']'}, {'(', ')'}, {'{', '}'}};

        for (int i = 0; i < s.Length; i++) {

            switch (s[i]) {
                case '[':
                case '{':
                case '(':
                    stack.Push(s[i]);
                    break;
                default:
                    if (stack.Count == 0 || map[stack.Peek()] != s[i]) {
                        return false;
                    }
                    else {
                        stack.Pop();
                    }
                    break;

            }

        }

        return stack.Count == 0;

    }
}
