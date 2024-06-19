public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        
        IList<IList<int>> outputList = new List<IList<int>>();
        Array.Sort(nums);
        var count = nums.Length;
        for(int i=0;i<count;i++)
        {
            if(i!=0 && (nums[i]==nums[i-1]))
            {
                continue;
            }
            for(int j=i+1;j<count;j++)
            {
                if(j-1!=i && (nums[j]==nums[j-1]))
                {
                    continue;
                }
                var k = j+1;
                var l = count -1;
                while(k<l){
                    var sumOfTerms = (long)nums[i] + (long)nums[j] + (long)nums[k] +(long)nums[l];
                    if(sumOfTerms>Int32.MaxValue){
                        return outputList;
                    }
                    if(sumOfTerms==target){
                        if(k-1 != j && (nums[k]==nums[k-1])){
                            k++;
                            continue;
                        }
                        if(l != count-1 && (nums[l]==nums[l+1])){
                            l--;
                            continue;
                        }
                        outputList.Add(new List<int>{nums[i],nums[j],nums[k],nums[l]});
                        l--;
                    }
                    else if(sumOfTerms>target){
                        l--;
                    }
                    else if(sumOfTerms<target){
                        k++;
                    }
                }
            }
        }
        return outputList;
    }
}