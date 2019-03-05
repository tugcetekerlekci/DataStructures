/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var dict1 = new Dictionary<int,List<int>>();
        var result = new List<int>();
 
        for(int i = 0; i<nums.Length; i++)
        {
				if (!dict1.ContainsKey(nums[i]))
				{
					var newList = new List<int>();
					newList.Add(i);
                	dict1.Add(nums[i],newList);
				}
				else 
				{
					var addToExistingList = dict1[nums[i]]; 
					addToExistingList.Add(i);
					dict1[nums[i]] = addToExistingList;
				}	
        }
		int dangerousValue = target/2;
		if (dict1.ContainsKey(dangerousValue))
		{
			if (dict1[dangerousValue].Count>1)
			{
				for(int i=0;i<2;i++)
				{
					result.Add(dict1[dangerousValue][i]);
				}
				return result.ToArray();
			}
            else
			{
				foreach(KeyValuePair<int, List<int>> pair in dict1)
	            {
					if(dict1.ContainsKey(target-pair.Key) && dict1[target-pair.Key] !=dict1[pair.Key] )
					{	
						Console.WriteLine("*************");
						result.Add(dict1[pair.Key].First());
						result.Add(dict1[target-pair.Key].First());
						return result.ToArray();
					}
				}
			}
		
		}
		else
		{
			foreach(KeyValuePair<int, List<int>> pair in dict1)
            {
				if(dict1.ContainsKey(target-pair.Key))
				{
					result.Add(dict1[pair.Key].First());
					result.Add(dict1[target-pair.Key].First());
					return result.ToArray();
				}
			}
		}
		
		return null;
		}
        
    }
