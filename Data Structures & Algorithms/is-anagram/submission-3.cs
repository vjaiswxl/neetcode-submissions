public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> hash1 = new Dictionary<char,int>();
        Dictionary<char,int> hash2 = new Dictionary<char,int>();

        if (s.Length != t.Length){
            return false;
        }

        for (int i = 0; i < s.Length; i++){
           if (hash1.ContainsKey(s[i])){
              hash1[s[i]]++;
           } else {
            hash1.Add(s[i],0);
           }
           if (hash2.ContainsKey(t[i])){
            hash2[t[i]]++;
           } else {
            hash2.Add(t[i],0);
           }
        }

        foreach(char c in hash1.Keys){
            if (!hash2.ContainsKey(c)){
                return false;              
            }
            if ( hash1[c] != hash2[c]) {
                return false;
            }  
        }
        
        return true;
    }
}
