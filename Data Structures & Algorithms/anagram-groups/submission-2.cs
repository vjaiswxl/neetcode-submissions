public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> resMap = new Dictionary<string,List<string>>();
        foreach (string str in strs){
            int[] hashtable = new int[26];
            foreach (char ch in str){
                hashtable[ch - 'a']++;               
            }
            string key = string.Join(',',hashtable);
            if (!resMap.ContainsKey(key)){
                resMap[key] = new List<string>();
            } 
               resMap[key].Add(str);
        }
        return resMap.Values.ToList<List<string>>();
    }
}
