/*
Given a binary tree, return the preorder traversal of its nodes' values.

Example:

Input: [1,null,2,3]
   1
    \
     2
    /
   3

Output: [1,2,3]*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
//root - left - right  
public class Solution {
    public IList<int> PreorderTraversal(TreeNode node) 
	{
		IList<int> list = new List<int>();
    
	    while(node != null) {
	        if(node.left == null) {
	            list.Add(node.val);
	            node = node.right;
	        }
	        else {
	            TreeNode nextNode = node.left;
	            TreeNode p = nextNode;
	            while(p.right != null) p = p.right;
	            list.Add(node.val);
	            p.right = node.right;
	            node = nextNode;
	        }
	    }
	    return list;
		
    }
}
