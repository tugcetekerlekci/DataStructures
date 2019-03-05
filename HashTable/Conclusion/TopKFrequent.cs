/*Given a non-empty array of integers, return the k most frequent elements.

Example 1:

Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]
Example 2:

Input: nums = [1], k = 1
Output: [1]
Note:

You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
Your algorithm's time complexity must be better than O(n log n), where n is the array's size.**/



public class Solution {
    public IList<int> TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> frequency = new Dictionary<int,int>();
        foreach(int num in nums)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num] = frequency[num]+1;
            }
            else
            {
                frequency.Add(num,1);
            }
        }
		
		Console.WriteLine(frequency);
		
		
		var result = new List<int>(); 
		
		var myList = frequency.ToList();

		myList.Sort((pair1,pair2) => pair2.Value.CompareTo(pair1.Value));
        
		Console.WriteLine(myList);
		
		for(int i =0; i<k;i++)
		{
			result.Add(myList[i].Key);
		
		}
		
		
		//Console.WriteLine((from kvp in result select kvp.Key).Distinct().ToList());
		return result;
		//return (from kvp in result select kvp.Key).Distinct().ToList();
    }
}
