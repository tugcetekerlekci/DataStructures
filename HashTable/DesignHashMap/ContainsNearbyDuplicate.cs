/**
Given an array of integers and an integer k, find out whether there are two distinct indices i and j in the array such that nums[i] = nums[j] and the absolute difference between i and j is at most k.

Example 1:

Input: nums = [1,2,3,1], k = 3
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1
Output: true
Example 3:

Input: nums = [1,2,3,1,2,3], k = 2
Output: false
**/

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (nums.Count()< 2)
        {return false;}
        var dict = new Dictionary<int,List<int>>();
        for(int i=0; i<nums.Count();i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                var tempList = new List<int>();
                tempList.Add(i);
                dict.Add(nums[i],tempList); 
            }
            else
            {
                var tempList = dict[nums[i]];
                tempList.Add(i);
                dict[nums[i]]= tempList;
            }
        }
		
         for(int i=0; i<dict.Count();i++)
         {
             if ( dict[nums[i]].Count>1)
             {
                var stack = new Stack<int>();
				Console.WriteLine(dict[nums[i]]);
				if(SmallerThanAtMost(dict[nums[i]],k))
				{
					return true;
				}
             }
         }
        return false;
    }
	
	public bool SmallerThanAtMost(List<int> arr, int k)
	{
		var stack = new Stack<int>();
		bool result = false;
		for (int i=0; i< arr.Count();i++)
		{
            while(stack.Count()!=0 && arr[i]-arr[stack.Peek()]<=k)
			{
				stack.Pop();
				result = true;
			}
			stack.Push(i);
		}
		return result; 
	}
}
