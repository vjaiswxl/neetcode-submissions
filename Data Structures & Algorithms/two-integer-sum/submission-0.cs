public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> res = new Dictionary<int,int>();

        for (int i =0 ; i < nums.Length; i++) {
            int diff = target - nums[i];
            
            if (res.ContainsKey(diff)){
                return [res[diff],i];
            }

            if (!res.ContainsKey(nums[i])){
                res.Add(nums[i],i);
            }
         
        }

        return [];
    }
}
