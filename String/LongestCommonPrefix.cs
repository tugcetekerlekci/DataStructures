/*Input: ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.*/

public class Solution {
    public string LongestCommonPrefix(string[] strs) 
	{
		if (strs == null || strs.Length == 0)
		{
		   return "";
		}
		int minLen = int.MaxValue;
		foreach(var str in strs)
		{
			minLen = Math.Min(minLen,str.Length);
		}
		int low =1; 
		int high = minLen;
		while(low<=high)
		{
			int mid = (low+high)/2;
			if (IsCommonPrefix(strs,mid))
			{
				low = mid+1;
			}
			else
			{
				high = mid-1;
			}
		}
		return strs[0].Substring(0, (low + high) / 2);
	}
	
	public bool IsCommonPrefix(string [] strs,int length)
	{
		String str1 = strs[0].Substring(0,length);
		for (int i =0 ;i< strs.Length;i++)
		{
			if (!strs[i].StartsWith(str1))
			{
				return false;
			}
		}
		return true;
	}
}
