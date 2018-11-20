/*Given two binary strings, return their sum (also a binary string).

The input strings are both non-empty and contains only characters 1 or 0.

Example 1:

Input: a = "11", b = "1"
Output: "100"
Example 2:

Input: a = "1010", b = "1011"
Output: "10101" */
public class Solution {
    public string AddBinary(string a, string b) {
        int lena = a.Count();
		int lenb = b.Count();
		int i=0;
		int carry = 0; 
		string result = "";
		while (i<lena || i<lenb || carry!=0)
		{
			var x = i<lena ? Char.GetNumericValue(a[lena-i-1]) : 0; 
			var y = i<lenb ? Char.GetNumericValue(b[lenb-i-1]) : 0;  
			result = (x+y+carry)%2 + result;
			carry = (int)(x+y+carry)/2;
			Console.WriteLine(result);
			i++;
		}
		Console.WriteLine("result is {0}",result);
		return result;
    }

}
