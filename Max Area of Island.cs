public class Solution {
    private static int m,n;
    public int MaxAreaOfIsland(int[][] grid) {
         m=grid.Length;
         n=grid[0].Length;
        int MaxArea=0;
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j]==1)
                {
                    int currentArea=DFS(grid,i,j);
                    MaxArea = Math.Max(MaxArea,currentArea);
                }
            }
        }
        return MaxArea;
    }
    private int DFS(int [][]grid,int i, int j)
    {
        if(i<0 || i>=m || j<0 || j>=n || grid[i][j]==0)
        {
            return 0;
        }
        grid[i][j]=0;
        int area=1;
        area += DFS(grid,i+1,j);
        area += DFS(grid,i-1,j);
        area += DFS(grid,i,j+1);
        area += DFS(grid,i,j-1);
        return area;
    
    }
}