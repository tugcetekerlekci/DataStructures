public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
		var resultSet = new HashSet<int>();
		if (nums1.Count() == 0 || nums2.Count() ==0) return resultSet.ToArray(); 
        var firstArray = new HashSet<int>();
		foreach(var element in nums1)
		{
			firstArray.Add(element);
		}
		var nums2Set = new HashSet<int>();
		foreach(var element in nums2)
		{
			nums2Set.Add(element);
		}
		
		foreach(var element in nums2Set)
		{
			if(!firstArray.Add(element))
			{
				resultSet.Add(element);
			}
		}
		
		return resultSet.ToArray();
    }
}
