/*
Given two arrays, write a function to compute their intersection.

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2,2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [4,9]
Note:

Each element in the result should appear as many times as it shows in both arrays.
The result can be in any order.
Follow up:

What if the given array is already sorted? How would you optimize your algorithm?
What if nums1's size is small compared to nums2's size? Which algorithm is better?
What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?
*/
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var firstArrayDictionary = new Dictionary<int,int>();
        var aggregationDictionary = new Dictionary<int,int>();
        for(int i=0 ; i<nums1.Count();i++)
        {
            if (firstArrayDictionary.ContainsKey(nums1[i]))
            {
                firstArrayDictionary[nums1[i]] = firstArrayDictionary[nums1[i]] +1;  
            }
            
            else
            {
                firstArrayDictionary.Add(nums1[i],1);
            }
            
            if (aggregationDictionary.ContainsKey(nums1[i]))
            {
                aggregationDictionary[nums1[i]] = aggregationDictionary[nums1[i]] +1;  
            }
            
            else
            {
                aggregationDictionary.Add(nums1[i],1);
            }
        }
        
        for(int i=0 ; i<nums2.Count();i++)
        {
            
            if (aggregationDictionary.ContainsKey(nums2[i]))
            {
                aggregationDictionary[nums2[i]] = aggregationDictionary[nums2[i]] +1;  
            }
            
            else
            {
                aggregationDictionary.Add(nums2[i],1);
            }
        
        }
        
        var resultList = new List<int>();
        foreach(KeyValuePair<int,int> pair in aggregationDictionary)
        {
           
            int keyValue = pair.Key;
            if (firstArrayDictionary.ContainsKey(pair.Key))
            {
                if (pair.Value != firstArrayDictionary[keyValue])
                {
                    int apperanceTimeForFirstArray = firstArrayDictionary[keyValue];
                    int apperanceTimeForSecondArray = pair.Value- firstArrayDictionary[keyValue];
                    int addTime; 
                    addTime = 
                        apperanceTimeForFirstArray<apperanceTimeForSecondArray ? apperanceTimeForFirstArray : apperanceTimeForSecondArray;
                    for(int i=0 ; i<addTime;i++)
                    {
                    resultList.Add(pair.Key);
                    
                    }
                }
            }
            
        }
        
        return resultList.ToArray();
        
    }
}
