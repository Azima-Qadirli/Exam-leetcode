public class Solution {
    int [] children;
    int minUnfairness;
public int DistributeCookies(int[] cookies, int k) {
    children = new int[k];
    minUnfairness = int.MaxValue;
    Helper(cookies,0,k);
    return minUnfairness;
}
private void Helper(int[]cookies,int idx,int k){
    if(idx>=cookies.Length){
        minUnfairness=Math.Min(children.Max(),minUnfairness);
        return;
    }
    for(int i=0;i<k;i++){
        children[i]+=cookies[idx];
        Helper(cookies,idx+1,k);
        children[i]-=cookies[idx];
    }
}
}