public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int closestSum = nums[0]+nums[1]+nums[2];

        for(int i=0;i<nums.Length-2;i++)
        {
            int left = i+1; //Pointer for the element to the right of nums[i]
            int right = nums.Length-1; //Pointer for the last element in the array

            while(left<right)
            {
                int currentSum = nums[i]+nums[left]+nums[right];
                if (Math.Abs(target-currentSum)<Math.Abs(target-closestSum))
                {
                    closestSum = currentSum;
                }
                if(currentSum<target)
                {
                    left++;
                }
                else if(currentSum>target)
                {
                    right--;
                }
             else
            {
                return target;
            }
            }
        }
        return closestSum;
    }
}