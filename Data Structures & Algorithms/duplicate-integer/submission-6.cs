public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        int curr = 1;
        for(int i = 0; i < nums.Length-1; i++){
            if (nums[i] == nums[curr]){
                return true;
            }
            curr++;
        }

        return false;
    }
}