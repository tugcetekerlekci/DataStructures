/*
Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

Examples:

s = "leetcode"
return 0.

s = "loveleetcode",
return 2.

*/
public class Solution {
    public int FirstUniqChar(string s) {
     var dict = new Dictionary<char,List<int>>();
     var charArray = s.ToCharArray();
    
     for(int i=0; i<charArray.Count();i++)
     {
        if (dict.ContainsKey(charArray[i]))
        {
            var tempList = dict[charArray[i]];
            tempList.Add(i);
            dict[charArray[i]] = tempList;
        }
        else
        {
            var tempList = new List<int>();
            tempList.Add(i);
            dict[charArray[i]] = tempList;
            
        }
    }
        
    foreach(KeyValuePair<char,List<int>> pair in dict)
    {
        if (pair.Value.Count == 1)
        {
            return pair.Value.First();
        }
    }
    return -1;
    }
}
