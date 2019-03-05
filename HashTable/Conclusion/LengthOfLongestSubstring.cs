/**Given a string, find the length of the longest substring without repeating characters.

Example 1:

Input: "abcabcbb"
Output: 3 
Explanation: The answer is "abc", with the length of 3. 
Example 2:

Input: "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3. 
             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.**/


public class Solution {
     public int LengthOfLongestSubstring(string s) {
        var characterSet = new HashSet<Char>();
		int length  = s.Length;
		int ans = 0;
		int i = 0;
		int j = 0;
        while (i < length  && j < length) 
		{
			char element = s[j];
			if (!characterSet.Contains(element))
			{
				characterSet.Add(element);
				j++;
				ans = Math.Max(ans,j-i);
			}
			else
			{
				if (i<length)
				{
					var charList = characterSet.ToList();
					var removedElement = charList[i];
					characterSet.Remove(removedElement);
					i++;
				}
			}
		}
		return ans;
    }
}
