public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int[] nextToNext = new int[2];
        int[] next = new int[2];

        for(int index=n-1;index>=0;index--)
        {
            int[] curr = new int[2];
            for(int canbuy=0;canbuy<2;canbuy++)
            {
                if(canbuy==1)
                    curr[canbuy]=Math.Max(-prices[index]+next[0],next[1]);
                else
                    curr[canbuy]=Math.Max(prices[index]+nextToNext[1],next[0]);
            }
            nextToNext=next;
            next=curr;
        }
        return next[1];
    }
}
