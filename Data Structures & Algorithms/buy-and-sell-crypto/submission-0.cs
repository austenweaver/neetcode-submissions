public class Solution {
    public int MaxProfit(int[] prices) {
        
        int maxProfit = 0;
        int minPrice = 101;


        for (int i = 0; i < prices.Length; i++) {
            if (minPrice > prices[i]) {
                minPrice = prices[i];
            }
            if (prices[i] - minPrice > maxProfit) {
                maxProfit = prices[i] - minPrice;
            }
        }

        return maxProfit;

    }
}
