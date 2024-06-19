public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        if(obstacleGrid==null || obstacleGrid.Length ==0 || obstacleGrid[0].Length==0 || obstacleGrid[0][0]==1)
        {
            return 0;
        }
        int m=obstacleGrid.Length;
        int n=obstacleGrid[0].Length;

        int[] previous = new int[n];
        int [] current = new int [n];
        previous[0]=1;

        for(int i=0; i<m;i++)
        {
            current[0] =obstacleGrid[i][0] == 1 ? 0 : previous[0];
            for(int j=1;j<n;j++)
            {
                current[j]  = obstacleGrid[i][j] == 1 ? 0 : current[j-1] + previous[j];
            }
            Array.Copy(current,previous,n);
        }
            return previous[n-1];

    }
}