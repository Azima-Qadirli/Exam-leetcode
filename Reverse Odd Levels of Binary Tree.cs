public class Solution {
    public TreeNode ReverseOddLevels(TreeNode root) {
        if(root==null)
        {
            return root;
        }
        Revers(root.left,root.right,true);
        return root;
    }
    private void Revers(TreeNode nodeLeft, TreeNode nodeRight, bool IsOdd )
    {
        if(nodeLeft == null && nodeRight == null)
        {
            return;
        }
        if(IsOdd)
        {
            var t = nodeLeft.val;
            nodeLeft.val=nodeRight.val;
            nodeRight.val = t;
        }
        Revers(nodeLeft.left,nodeRight.right, !IsOdd);
        Revers(nodeLeft.right, nodeRight.left, !IsOdd);
    }
}