/*
Given an input string, reverse the string word by word.

Example:  

Input: "the sky is blue",
Output: "blue is sky the".
Note:

A word is defined as a sequence of non-space characters.
Input string may contain leading or trailing spaces. However, your reversed string should not contain leading or trailing spaces.
You need to reduce multiple spaces between two words to a single space in the reversed string.
Follow up: For C programmers, try to solve it in-place in O(1) space.*/

public class Solution {
    public string ReverseWords(string s) {
		if (s.Trim().Length == 0)
		{
			return "";
		}
        if (!s.Contains(" "))
        {
            return s; 
        }
		string[] words = Reverse(s).Split(null);
		words =  words.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    	if (words.Length == 1)
        {
            return words[0].Replace(" ","");
        }
		
		StringBuilder result = new StringBuilder();
		
		var last = words.Last();
		foreach(var word in words)
		{
			if (word == last)
			{
				result.Append(Reverse(word));
			}
			else
			{
				result.Append(Reverse(word) + " ");
			}
		}
		return result.ToString();
	}
	
	public string Reverse(string s)
	{
		StringBuilder str = new StringBuilder();
		str.Append(s);
		int start = 0; 
		int end = s.Length-1;
		while(start<end)
		{
			var temp = str[start];
			str[start]= str[end];
			str[end] = temp;
			start++;
			end--;
		}
		return str.ToString();
	}
}
