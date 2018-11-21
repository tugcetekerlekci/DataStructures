/*
Write a function that takes a string as input and returns the string reversed.

Example 1:

Input: "hello"
Output: "olleh"
Example 2:

Input: "A man, a plan, a canal: Panama"
Output: "amanaP :lanac a ,nalp a ,nam A"
*/
public class Solution {
    public string ReverseString(string s) {
        int firstPointer = 0;
		int secondPointer = s.Length -1; 
		StringBuilder result  = new StringBuilder(s);
		while(firstPointer <secondPointer)
		{
			result = SwapElements(firstPointer,secondPointer,result);
			
			firstPointer++;
			secondPointer--;
		}
		return result.ToString();
    }
	
	public StringBuilder SwapElements(int firstIndex,int secondIndex,StringBuilder s)
	{

		//Console.WriteLine("DEGISMEDEN ONCE FIRST INDEX {0}",s[firstIndex]);
		var temp = s[firstIndex];
		s[firstIndex] = s[secondIndex];
		//Console.WriteLine("DEGISTIKTEN SONRA FIRST INDEX {0}",s[firstIndex]);
		s[secondIndex] = temp;
		//Console.WriteLine(result);
		return s;
	}
}
