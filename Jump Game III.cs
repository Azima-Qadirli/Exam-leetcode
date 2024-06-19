public class Solution {
    public bool CanReach(int[] arr, int start) {
        if(start<0 || start>=arr.Length || arr[start] == -1)
        return false;

        if(arr[start] == 0)
        return true;
        
        var num = arr[start];
        arr[start]= -1;
        return CanReach(arr,start+num) || CanReach(arr,start-num);
    }
}