/*
Given inorder and postorder traversal of a tree, construct the binary tree.

Note:
You may assume that duplicates do not exist in the tree.

For example, given

inorder = [9,3,15,20,7]
postorder = [9,15,7,20,3]
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
    public TreeNode BuildTree(int[] inOrder, int[] postOrder) {
        if (inOrder.Length != postOrder.Length)
		{
			return null;
		}
		Index postIndex = new Index();
		int length = inOrder.Length;
		postIndex.Value = length-1;
		return BuildUtil(inOrder,postOrder,0,length-1,postIndex);
    }
	TreeNode BuildUtil(int [] inorder, int [] post,int inOrderStart, int inOrderEnd,Index postIndex)
	{

		//if the node does not have any children
		if (inOrderStart > inOrderEnd) 
		{
			return null;
		}
		//else find the index of the node for inorder traversel
				
		TreeNode node = new TreeNode(post[postIndex.Value]);
		postIndex.Value--;
		
		if (inOrderStart == inOrderEnd) 
		{
			return node;
		}
		
		int inOrderIndex = Search(inorder,inOrderStart,inOrderEnd,node.val);
		
		node.right = BuildUtil(inorder,post,inOrderIndex+1,inOrderEnd,postIndex);
		node.left = BuildUtil(inorder,post,inOrderStart,inOrderIndex-1,postIndex);
		
		return node;
	}
	
	public int Search(int [] arr, int start, int end, int value)
	{
		int i;
		for (i= start; i<=end;i++)
		{
			if (arr[i]== value)
			{
				break;
			}
		}
		return i; 
	
	}
	public class Index
	{
		public int Value;
	}
	
	public void preOrder(TreeNode node) 
    { 
        if (node == null) 
            return; 
       Console.WriteLine(node.val + " "); 
        preOrder(node.left); 
        preOrder(node.right); 
    } 
}
