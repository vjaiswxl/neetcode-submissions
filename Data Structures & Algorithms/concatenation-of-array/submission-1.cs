public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[2*n];
        int count = 0;
        for (int i = 0; i < ans.Length; i++){
            if (count == n){
                count = 0; 
            }
            ans[i] = nums[count];
            count ++;
        }

        return ans;
    }
}