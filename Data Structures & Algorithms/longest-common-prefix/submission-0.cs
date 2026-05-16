public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string res = "";
        for (int i = 0; i < strs[0].Length; i++){
           char curr = strs[0][i];
         
           for (int j =1; j < strs.Length; j++){
            if (i >= strs[j].Length || strs[j][i] != curr){
                return res;
            }
           }
           res += strs[0][i];
        }

        return res;
    }
}