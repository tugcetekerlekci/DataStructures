/*In a given integer array nums, there is always exactly one largest element.

Find whether the largest element in the array is at least twice as much as every other number in the array.

If it is, return the index of the largest element, otherwise return -1.

Example 1:

Input: nums = [3, 6, 1, 0]
Output: 1
Explanation: 6 is the largest integer, and for every other number in the array x,
6 is more than twice as big as x.  The index of value 6 is 1, so we return 1.
 

Example 2:

Input: nums = [1, 2, 3, 4]
Output: -1
Explanation: 4 isn't at least as big as twice the value of 3, so we return -1.*/
public class Solution {
    public int DominantIndex(int[] nums) {
        var list = nums.ToList();
        if (list.Count == 1)
        {
            return 0 ;
        }
        var biggest = nums[0];
        for(int i =1; i<list.Count;i++)
        {
            if (biggest<list[i])
            {
                biggest = list[i];
                
            }
        }
        
        var biggestIndex = list.IndexOf(biggest);
        list.RemoveAt(biggestIndex);
        //Console.WriteLine("biggie {0} ",biggest);
        if (list.Count>0)
        {
            var newBiggest = list[0];    
            for(int i =1; i<list.Count;i++)
            {
                if (newBiggest<list[i])
                {
                    newBiggest = list[i];
                }
            }
            if (newBiggest *2 <= biggest)
            {
                return biggestIndex;
            }    
        }
        
        
        return -1;
    }
}
