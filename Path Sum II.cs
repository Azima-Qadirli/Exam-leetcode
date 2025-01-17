public class Solution {
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        List<IList<int>> result = new List<IList<int>>();
        List<int> currentPath = new List<int>();
        Dfs(root,targetSum, currentPath,result);
        return result;
}
private void Dfs(TreeNode node, int targetSum, List<int> currentPath, List<IList<int>> result){
    if(node==null)
    return;
    currentPath.Add(node.val);

    if(node.left==null && node.right==null && targetSum==node.val)
    result.Add(new List<int>(currentPath));

    Dfs(node.left,targetSum-node.val, currentPath,result);
    Dfs(node.right, targetSum-node.val, currentPath,result);
    currentPath.RemoveAt(currentPath.Count-1);


}
}