public class Solution {
    public int[][] Merge(int[][] intervals) {
        List<int[]> result = new List<int[]>();

        Array.Sort(intervals,(a,b)=>a[0].CompareTo(b[0]));

        result.Add(intervals[0]); // Add first interval to the result array

        for(int i=1;i<intervals.Length;i++)
        {
            if(result.Last()[1]<intervals[i][0])
            {
                result.Add(intervals[i]);
            }
            if(result.Last()[1]<intervals[i][1])
            {
                result.Last()[1]=intervals[i][1];
            }
        }
        return result.ToArray();
    }
}