/*
Input: [1,null,2,3]
   1
    \
     2
    /
   3

Output: [3,2,1]*/
public IList<int> PostorderTraversal(TreeNode root){
        List<TreeNode> list = new List<TreeNode>();
        Stack<int> output = new Stack<int>();
        var resultSet  = new List<int>();
        if (root == null)
        {
            var empty = new List<int>() {};
            return empty;
        }
        list.Add(root);
        while(list.Count != 0)
        {
            var count = list.Count;
            var node = list[count-1] ;
            list.RemoveAt(count-1);
            output.Push(node.val);
            if (node.left != null)
            {
                list.Add(node.left);
            }
            if (node.right != null)
            {
                list.Add(node.right);
            }
        }
        
        foreach (var element in output)
        {
            resultSet.Add(element);
        }
        return resultSet;
    }
    
 

}
