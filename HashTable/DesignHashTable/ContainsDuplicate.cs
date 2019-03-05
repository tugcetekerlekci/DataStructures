public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> MySet = new HashSet<int>();
        foreach(var num in nums)
        {
            MySet.Add(num);
        }
        return (MySet.Count == nums.Length) ? false : true;
    }
}
