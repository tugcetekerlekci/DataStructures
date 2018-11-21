/*
Given preorder and inorder traversal of a tree, construct the binary tree.

Note:
You may assume that duplicates do not exist in the tree.

For example, given

preorder = [3,9,20,15,7]
inorder = [9,3,15,20,7]
Return the following binary tree:

    3
   / \
  9  20
    /  \
   15   7
   */
   /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
	public TreeNode BuildTree(int [] preOrder,int [] inOrder)
	{
		return Helper(0, 0, inOrder.Length - 1, preOrder, inOrder);	
	}
	public TreeNode Helper(int preStart,int inStart,int inEnd,int [] preOrder, int [] inOrder)
	{
		if (preStart>preOrder.Length-1 || inStart>inEnd)
		{
			return null;
		}
		TreeNode root = new TreeNode(preOrder[preStart]);
		int inIndex = 0; 
		for (int i = inStart; i<=inEnd;i++)
		{
			if (inOrder[i] == root.val) {
            inIndex = i;
        	}
		}
		root.left = Helper(preStart + 1, inStart, inIndex - 1, preOrder, inOrder);
	    root.right = Helper(preStart + inIndex - inStart + 1, inIndex + 1, inEnd, preOrder, inOrder);
	    return root;
	
	}
}
