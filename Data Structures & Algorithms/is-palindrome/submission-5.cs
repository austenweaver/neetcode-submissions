public class Solution {
    public bool IsPalindrome(string s) {

        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            while (left < right && ((s[left] < 'A' || s[left] > 'Z') && (s[left] < 'a' || s[left] > 'z') && (s[left] <'0' || s[left] > '9'))) {
                left++;
            }
            while ((right > left && (s[right] < 'A' || s[right] > 'Z') && (s[right] < 'a' || s[right] > 'z') && (s[right] <'0' || s[right] > '9'))) {
                right--;
            }

            if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                return false;
            }

            left++;
            right--;
        }
        return true;
    }
}
