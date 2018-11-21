public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0; 
        int right = nums.Count()-1;
        while(left<=right)
        {
            int mid = (left+right)/2;
            if (target == nums[mid])
            {
                return mid;
            }
            if (nums[mid]<target)
            {
                left = mid+1;
            }
            if (nums[mid]>target)
            {
                right = mid-1;
            }
        }
        return -1; 
    }
}
