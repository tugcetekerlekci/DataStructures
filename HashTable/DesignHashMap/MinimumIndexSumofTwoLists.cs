/*
Suppose Andy and Doris want to choose a restaurant for dinner, and they both have a list of favorite restaurants represented by strings.

You need to help them find out their common interest with the least list index sum. If there is a choice tie between answers, output all of them with no order requirement. You could assume there always exists an answer.

Example 1:
Input:
["Shogun", "Tapioca Express", "Burger King", "KFC"]
["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"]
Output: ["Shogun"]
Explanation: The only restaurant they both like is "Shogun".
Example 2:
Input:
["Shogun", "Tapioca Express", "Burger King", "KFC"]
["KFC", "Shogun", "Burger King"]
Output: ["Shogun"]
Explanation: The restaurant they both like and have the least index sum is "Shogun" with index sum 1 (0+1).
*/

public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        var set = new HashSet<string>();
        var list = new List<string>();
        var minIndexDictionary = new Dictionary<string,int>();
        foreach(var element in list1)
        {
            set.Add(element);
            list.Add(element);
        }
        for(int i=0; i<list2.Count();i++)
        {
            if (!set.Add(list2[i]))
            {
                var indexForFirstList = list.IndexOf(list2[i]);
                var totalIndex = indexForFirstList + i;
                if(minIndexDictionary.ContainsKey(list2[i]))
                {
                    if (minIndexDictionary[list2[i]]> totalIndex)
                    {
                        minIndexDictionary[list2[i]] = totalIndex;
                    }
                    
                }
                else
                {
                    minIndexDictionary.Add(list2[i],totalIndex);
                }
            }
        }
        var result = new List<string>();
		var k = minIndexDictionary.OrderBy(kvp => kvp.Value).First();
        
		var allMins = minIndexDictionary.Where(x=> x.Value == k.Value);
		
		Console.WriteLine(allMins);
        foreach(var el in allMins)
		{
			result.Add(el.Key);
		}
		return result.ToArray();
    }
}
