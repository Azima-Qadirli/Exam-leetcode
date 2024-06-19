public class Solution {
    public int StoneGameII(int[] piles) {
        int n = piles.Length;
        var sums = new int[n];
        sums[n-1] = piles[n-1];
        for(int i = n -2; i>=0;i--) sums[i] = sums[i+1] + piles[i]; // sums[i] contains sum of rest piles starting from index i
        var arr= new int[n,n];// for storing points and re-use it for other player
        return dfs(0,1);//Alise start the game so s=0 and M=1

        int dfs(int s, int m){
            if(s == n) return 0; //if we reach to end of piles return 0
            if(2*m >= n - s) return sums[s];// if number of items staring from s to end of piles is less than 2*m, player can choose all of them and we can return sums[s]
            if(arr[s,m] != 0) return arr[s,m];// if we calculated arr[s,m] before for other player we can return it
            var min=Int32.MaxValue;
            for(var i=1;i<=2*m;i++) min=Math.Min(min,dfs(s+i,Math.Max(m,i)));// we want to find less points for other player on next turn
            return arr[s,m]=sums[s]-min;// the point of player will be equal sum[s] minus other player minimum next turn
        }
    }
}