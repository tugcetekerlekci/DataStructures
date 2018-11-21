/*
Given a binary tree, return the inorder traversal of its nodes' values.

Example:

Input: [1,null,2,3]
   1
    \
     2
    /
   3

Output: [1,3,2]*/
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
    /*public IList<int> InorderTraversal(TreeNode root)
	{
        List<int> list = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode cur = root;     
        while(cur!=null || stack.Count()!=0)
        {
            while(cur!=null)
            {
                stack.Push(cur);
                cur = cur.left;
            }
            cur = stack.Pop();
            list.Add(cur.val);
            cur = cur.right;
        }

        return list;
    }
    
    // recursive approach 
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        helper(root,res);
        return res;
    }
    
    public void helper (TreeNode root, List<int> res)
    {
        if (root !=null)
        {
            if (root.left !=null)
            {
                helper(root.left,res);
            }
            res.Add(root.val);
            if (root.right !=null)
            {
                helper(root.right,res);
            }
            
        }
    }
    
    */
    //Suggested approach
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode curr = root; 
        while (curr !=null || stack.Count !=0)
        {
            while (curr !=null)
            {
                stack.Push(curr);
                curr = curr.left;
            }
            curr = stack.Pop();
            res.Add(curr.val);
            curr = curr.right;
        }
        return res;        
    }
    
    
}
