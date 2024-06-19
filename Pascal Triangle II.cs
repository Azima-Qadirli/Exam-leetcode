public class Solution {
    public IList<int> GetRow(int rowIndex) {
        if (rowIndex < 0)
            throw new ArgumentException("rowIndex must be non-negative.");

        List<int> row = new List<int>();
        
        for (int i = 0; i <= rowIndex; i++) {
            row.Insert(0, 1); // Insert 1 at the beginning of the row
            
            for (int j = 1; j < row.Count - 1; j++) {
                row[j] = row[j] + row[j + 1]; // Update values in between
            }
        }
        
        return row;
    }
}