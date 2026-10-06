public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        Stack<int> stack = new Stack<int>();
        int[] results = new int[temperatures.Length];

        stack.Push(0);

        for (int i = 1; i < temperatures.Length; i++) {

            if (stack.Count != 0) {
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
                    // Console.WriteLine($"Writing {i - stack.Peek()} to results[{stack.Peek()}] ({temperatures[i]} > {temperatures[stack.Peek()]})");
                    results[stack.Peek()] = i - stack.Peek();
                    // Console.WriteLine($"Popping {stack.Peek()}");
                    stack.Pop();
                }
            }
            // Console.WriteLine($"Pushing {i}");
            stack.Push(i);

            // Console.WriteLine(results.Length);
        }

        return results;        
    }
}
