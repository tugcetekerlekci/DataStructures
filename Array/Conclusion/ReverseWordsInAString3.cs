/*
Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

Example 1:
Input: "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"
Note: In the string, each word is separated by single space and there will not be any extra space in the string.*/

public class Solution {
    public string ReverseWords(string s) {
		if (s.Trim().Length == 0)
		{
			return "";
		}
        string[] words = s.Split(null);
		words = words.Where(x=>!string.IsNullOrEmpty(x)).ToArray();
		if (words.Length == 1)
        {
            return Reverse(words[0].Replace(" ",""));
        }
		StringBuilder result = new StringBuilder();
		var last = words.Last();
		for(int i=0; i<words.Length;i++)
		{
			if (i== words.Length-1)
			{
				result.Append(Reverse(words[i]));
			}
			else
			{
				result.Append(Reverse(words[i]) + " ");
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
