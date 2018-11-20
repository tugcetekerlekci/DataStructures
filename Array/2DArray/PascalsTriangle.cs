/*
Example:

Input: 5
Output:
[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]
*/
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var resultList = new List<IList<int>>();
		if (numRows == 0 ) 
		{
			return resultList;
		}
		for (int i = 1 ; i<= numRows ; i++)
		{
			var ListElement = new List<int>();		
			
			if (i == 1 ) { ListElement.Add(1); }
			else if (i == 2 ) 
			{ 
				ListElement.Add(1); 
				ListElement.Add(1);		
			}
			else
			{
				
				var previousList = resultList[i-2];
				ListElement.Add(1);
				for (int k=0; k<previousList.Count()-1;k++)
				{
					ListElement.Add(previousList[k]+previousList[k+1]);
				}
				ListElement.Add(1);
			}
			resultList.Add(ListElement);
		}
		return resultList;
    }
}
