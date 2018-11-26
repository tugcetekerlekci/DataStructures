/*
Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

(i.e.,  [0,1,2,4,5,6,7] might become  [4,5,6,7,0,1,2]).

Find the minimum element.

You may assume no duplicate exists in the array.

Example 1:

Input: [3,4,5,1,2] 
Output: 1
Example 2:

Input: [4,5,6,7,0,1,2]
Output: 0
*/
public class Solution {
    public int FindMin(int[] nums) {
        if (nums.Count() == 1) {return nums[0];}
        for (int i =0 ; i<nums.Count(); i++)
        {
            if (i == nums.Count()-1 && nums[i-1]<nums[i])
			{
				return nums[0];
			}
            if (nums[i+1]<nums[i])
            {
                return nums[i+1]; 
            }
        }
        return 0;
    }
}
