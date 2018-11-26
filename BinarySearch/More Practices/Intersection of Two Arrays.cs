/*
Given two arrays, write a function to compute their intersection.

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Note:

Each element in the result must be unique.
The result can be in any order.
*/
public class Solution {
    public Solution()
    {
        ElementIntersectionDictionary = new Dictionary<int,int>();
        ResultList = new List<int>();
    }
    public int[] Intersection(int[] nums1, int[] nums2) {
        foreach(int num in nums1)
        {
            PutFirstArrayToTheDictionary(num);
            
        }
        foreach(int num in nums2)
        {
            AddSecondArrayToTheDictionary(num);
            
        }
        
        FindTheIntersection(ElementIntersectionDictionary);
        return ResultList.ToArray();
        
        
        
    }
    
    public void PutFirstArrayToTheDictionary(int key)
    {
        if (!ElementIntersectionDictionary.ContainsKey(key))
        {
            ElementIntersectionDictionary[key] = key; 
        }

    }
    
    public void AddSecondArrayToTheDictionary(int key)
    {
        if (ElementIntersectionDictionary.ContainsKey(key))
        {
            ElementIntersectionDictionary[key] = ElementIntersectionDictionary[key]+1; 
        }

    }
    
    public List<int> FindTheIntersection(Dictionary<int,int> inputDictionary)
    {
        foreach(KeyValuePair<int,int> pair in inputDictionary)
        {
            if(pair.Key != pair.Value)
            {
                ResultList.Add(pair.Key);   
            }
        }
        
        return ResultList;
        
    }
    
    
    public Dictionary<int,int> ElementIntersectionDictionary {get; set;}
    public List<int> ResultList {get; set;}
    
}
