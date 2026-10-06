public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) {
            return false;
        }


        Dictionary<char,int> dict = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++) {

            if (dict.ContainsKey(s[i])) {
                dict[s[i]]++;
            }
            else {
                dict[s[i]] = 1;
            }

            if (dict.ContainsKey(t[i])) {
                dict[t[i]]--;
            }
            else {
                dict[t[i]] = -1;
            }
        }

        HashSet<int> vals = new HashSet<int>(dict.Values);
        return vals.Count == 1 && vals.Contains(0);
    }
}
