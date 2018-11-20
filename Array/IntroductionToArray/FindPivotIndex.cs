

public class Solution {
    public int PivotIndex(int[] nums) {
     int sum = 0; 
     foreach(var num in nums){
         sum = sum+num;
     }   
     int leftSum = 0 ; 
     for (int i =0; i<nums.Length;i++)
     {
         if (leftSum == sum-leftSum-nums[i]) return i;
         leftSum = leftSum+nums[i];
     }
        return -1;
    }
}
