public class Solution {
    public int LongestPalindromeSubseq(string s) {
        int n = s.Length;
        int[,] dp = new int[n,n];


        //Every single character is a palindrome of length 1
        for(int i=0;i<n;i++)
        {
            dp[i,i]=1;
        }

        //Build the dp table

        for(int length=2;length<=n;length++)
        {
            for(int i=0;i<=n-length;i++)
            {
                int j =i+length-1;
                dp[i,j]=dp[i+1,j-1]+2;
                if(s[i]==s[j])
                {
                    
                    dp[i,j]=dp[i+1,j-1]+2;
                }
                else
            {
                dp[i,j]=Math.Max(dp[i+1,j],dp[i,j-1]);
            }
            }
            
        }
        return dp[0,n-1];
    }
}