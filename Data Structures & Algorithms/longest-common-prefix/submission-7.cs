public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string res = "";
        if (strs == null || strs.Length == 0) return "";

        for (int j = 0; j < strs[0].Length; j++) {
            for (int i = 1; i < strs.Length; i++) {
                if (j >= strs[i].Length || strs[i][j] != strs[0][j]) {
                    return res;
                }
            }
            res +=strs[0][j];
        }

        return res;
    }
}