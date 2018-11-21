/*
Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.

The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.

Note:

Your returned answers (both index1 and index2) are not zero-based.
You may assume that each input would have exactly one solution and you may not use the same element twice.
Example:

Input: numbers = [2,7,11,15], target = 9
Output: [1,2]
Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.*/
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
		var result = new List<int>();
		int i=0;
		while(i<numbers.Length)
		{
			var searchNumber = Math.Abs(target - numbers[i]);
			int index = Array.BinarySearch(numbers,searchNumber);
			if (index > -1 && i!=index)
			{
				result.Add(Math.Min(index,i)+1);
				result.Add(Math.Max(index,i)+1);
				return result.ToArray();
			}
			i++;
		}
		return result.ToArray();
		
	}
}
	


/*public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
		int lastIndex = numbers.Length-1; 
        foreach(var element in numbers)
		{
			if (element> target)
			{
				numbers.ToList().Remove(element);
			}
		}
		for(int firstIndex = 0 ; firstIndex<numbers.Length;firstIndex++)
		{
			while (firstIndex<numbers.Length-1 && lastIndex>0)
			{
			    if (numbers[firstIndex] + numbers[lastIndex] == target)
				{
					return new [] {firstIndex+1,lastIndex+1};
				}
				lastIndex--;
			}
			lastIndex = numbers.Length-1; 
		}
		var res = new List<int>();
    	return res.ToArray() ;
	}
}*/
