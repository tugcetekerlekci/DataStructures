
/*
Longest Substring Without Repeating Characters
  Go to Discuss
Given a string, find the length of the longest substring without repeating characters.

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
             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

*/



public int LengthOfLongestSubstring(string s) {
var unicalCharecters = new Dictionary<char,int>();

    int maxSubString = 0;
    int currentMax = 0;
    int startIndex=0;

    for(int i=0;i<s.Length;i++){
        
        char currentChar = s[i];
        if (unicalCharecters.ContainsKey(currentChar) && unicalCharecters[currentChar]>=startIndex){
        
            currentMax = i-unicalCharecters[currentChar]-1;
        
            startIndex = unicalCharecters[currentChar];
        }
        unicalCharecters[currentChar] = i;
        
        currentMax++;
        
        maxSubString =Math.Max(currentMax,maxSubString);
    }
    return maxSubString;
    
}
