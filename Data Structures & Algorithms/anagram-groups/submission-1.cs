public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        List<List<string>> results = new List<List<string>>();

        Dictionary<string,int> groups = new Dictionary<string,int>();

        for (int i = 0; i < strs.Length; i++) {

            int[] freqs = new int[26];

            for (int j = 0; j < strs[i].Length; j++) {
                freqs[strs[i][j] - 'a']++;
            }

            string key = String.Join(",",freqs);

            if (groups.TryGetValue(key, out var index)) {
                results[index].Add(strs[i]);
            }
            else {
                groups[key] = results.Count;
                results.Add(new List<string>());
                results[results.Count - 1].Add(strs[i]);
            }
        }
        return results;
    }
}
