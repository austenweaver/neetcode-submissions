public class Solution {

    // Dynamic programming - top-down/memoization

    public int[] cache;

    public int ClimbStairs(int n) {  

        cache = new int[n+1];

        for (int i = 0; i < n+1; i++) {
            cache[i] = -1;
        }

        return dfs(n);
    }


    public int dfs(int n) {
        if (cache[n] != -1) {
            return cache[n];
        }

        if (n == 1) {
            return 1;
        }

        if (n == 2) {
            return 2;
        }

        cache[n] = dfs(n - 1) + dfs(n - 2);
        return cache[n];
    } 
}

    

