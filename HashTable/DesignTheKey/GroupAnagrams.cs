/**
 Group Anagrams
  Go to Discuss
Given an array of strings, group anagrams together.

Example:

Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
Output:
[
  ["ate","eat","tea"],
  ["nat","tan"],
  ["bat"]
]
Note:

All inputs will be in lowercase.
The order of your output does not matter.
**/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        var dict = new Dictionary<string,List<string>>();
        foreach(var str in strs)
        {
            string sortedStr = String.Concat(str.OrderBy(c => c));
			
            if (!dict.ContainsKey(sortedStr))
			{
				var temp = new List<string>();
				temp.Add(str);
				dict.Add(sortedStr,temp);
			}
			else
			{
				List<string> tempList;
				if (!dict.TryGetValue(sortedStr, out tempList)) {}
				tempList.Add(str);
				dict[sortedStr] = tempList;
			}
			
        }
       List<IList<string>> resultList = new List<IList<string>>();
        foreach(KeyValuePair<string,List<string>> pair in dict)
        {
            resultList.Add(pair.Value);
        }
        return resultList;
        
    }
}
