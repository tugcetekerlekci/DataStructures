/*
Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).

For example, this binary tree [1,2,2,3,4,4,3] is symmetric:

    1
   / \
  2   2
 / \ / \
3  4 4  3
But the following [1,2,2,null,3,null,3] is not:
    1
   / \
  2   2
   \   \
   3    3
   */

 

    /*
    public bool IsSymmetric(TreeNode root) {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        q.Enqueue(root);
        while(q.Count() != 0)
        {
            var t1 = q.Dequeue();
            var t2 = q.Dequeue();
            if (t1== null && t2 == null ) continue;
            if (t1 == null || t2 == null ) return false;
            if (t1.val != t2.val) return false;
            q.Enqueue(t1.left);
            q.Enqueue(t2.right);
            q.Enqueue(t2.left);
            q.Enqueue(t1.right);
        }
        return false;
    }*/
public class Solution {
    
    public bool IsSymmetric(TreeNode root) {
        return IsMirror(root,root);
    }
    
    public bool IsMirror(TreeNode t1, TreeNode t2)
    {
        if (t1 == null && t2== null) return true; 
        if (t1 == null || t2 == null) return false; 
        return (t1.val==t2.val) && IsMirror(t1.left, t2.right) && IsMirror(t1.right,t2.left);
    }
}
