public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> counts = new Dictionary<int,int>();
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>();

        for (int i = 0; i < nums.Length; i++) {

            counts[nums[i]] = counts.GetValueOrDefault(nums[i]) + 1;
            
        }

        foreach (var pair in counts) {
            pq.Enqueue(pair.Key, -pair.Value);
        }


        int[] results = new int[k];

        for (int i = 0; i < k; i++) {
            results[i] = pq.Dequeue();
        }

        return results;
    }
}
