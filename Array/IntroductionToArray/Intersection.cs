void Main()
{
	var sol = new Solution();
	var arr1 = new [] {1,2,2,1};
	var arr2 = new [] {2,2};
	var arr3 = new [] {4,9,5};
	var arr4 = new [] {9,4,9,8,4};
	Console.WriteLine(sol.Intersection(arr1,arr2));
	Console.WriteLine(sol.Intersection(arr3,arr4));
}

/*
Given two arrays, write a function to compute their intersection.
Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]

*/
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
		var resultSet = new HashSet<int>();
		if (nums1.Count() == 0 || nums2.Count() ==0) return resultSet.ToArray(); 
        var firstArray = new HashSet<int>();
		foreach(var element in nums1)
		{
			firstArray.Add(element);
		}
		var nums2Set = new HashSet<int>();
		foreach(var element in nums2)
		{
			nums2Set.Add(element);
		}
		
		foreach(var element in nums2Set)
		{
			if(!firstArray.Add(element))
			{
				resultSet.Add(element);
			}
		}
		
		return resultSet.ToArray();
    }
}
