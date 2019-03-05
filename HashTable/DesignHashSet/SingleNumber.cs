//Given a non-empty array of integers, every element appears twice except for one. Find that single one.
public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int,int> DuplicationCounter = new Dictionary<int,int>();
        foreach (var num in nums)
        {
            if(DuplicationCounter.ContainsKey(num))
            {
                DuplicationCounter[num] = DuplicationCounter[num] +1; 
            }
            else
            {
                DuplicationCounter.Add(num,num);
            }
        }
        foreach(KeyValuePair<int, int> pair in DuplicationCounter)
        {
            if (pair.Key == pair.Value)
            {
                return pair.Key;
            }
            
        }
        return 0;
    }
        
}
