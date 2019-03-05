
/**
Given a binary tree, return all duplicate subtrees. For each kind of duplicate subtrees, you only need to return the root node of any one of them.

Two trees are duplicate if they have the same structure with same node values.

Example 1:

        1
       / \
      2   3
     /   / \
    4   2   4
       /
      4
The following are two duplicate subtrees:

      2
     /
    4
and

    4
Therefore, you need to return above trees' root in the form of a list.



 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
     
 public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
 {
 	if (root == null)  return new List<TreeNode>();
	Dictionary<string,TreeNode> map = new Dictionary<string,TreeNode>();
	Helper(root,map);
	IList<TreeNode> res = new List<TreeNode>();
	foreach(KeyValuePair<string,TreeNode> element in map)
	{
		
		if (element.Value != null )
		{
			//Console.WriteLine("here");
			//Console.WriteLine(element);
			res.Add(element.Value);
		}
	}
 	Console.WriteLine(res);
 	return res;
 }

public string Helper(TreeNode node, Dictionary<string,TreeNode> map)
{
	if(node.left == null && node.right == null)
	{
		string str = "" + node.val;
		if (!map.ContainsKey(str))
		{
			map.Add(str,null);
		}
		else
		{
			map[str] = node;
		}
		return str;
	}
	
	string left = "";
	if(node.left !=null)
	{
		left = Helper(node.left,map);
	}
	
	string right = "";
	if (node.right !=null)
	{
		right = Helper(node.right,map);
	}
	string str2  =left + "#" + right + "#" + node.val;
	if (!map.ContainsKey(str2))
	{
		map.Add(str2,null);
	}
	else
	{
		map[str2] = node;
	}
	
	return str2;
}
}
