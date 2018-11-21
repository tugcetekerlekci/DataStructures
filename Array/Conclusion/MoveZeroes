/*
Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Example:

Input: [0,1,0,3,12]
Output: [1,3,12,0,0]*/
public class Solution {
    public void MoveZeroes(int[] nums) {
        int zeroCount = 0;
        int nonZeroCount =0; 
        for (int i=0; i<nums.Count();i++)
        {
            if (nums[i]== 0)
            {
                zeroCount++;
            }
            else
            {
                nums[i-zeroCount] = nums[i];
                nonZeroCount++;
            }
        }
        if (zeroCount>0)
        {
            for(int i=0; i<zeroCount;i++)
            {
                nums[nonZeroCount+i] = 0;
            }
        }
	}
}
