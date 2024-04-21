namespace ProgrammingQuestions
{
    public class SubArraysOfSum
    {
       public int SubarraySum(int[] nums, int k) {
        if(nums.Length == 0)
            return 0;
        if(nums.Length == 1 && nums[0] == k){
            return 1;
        }
        int totalNumOfSubArrays = 0;
        int i =0;
        int j =1;
        int sum = 0; 
        

        while(i<nums.Length && j < nums.Length){
            if(sum + nums[j] < k ){
                sum += nums[i] + nums[j];
                // if(sum == k){
                //     totalNumOfSubArrays +=1;
                //     sum=0;
                //     i++;j++;
                // }else if(sum<k){
                //     j++;
                // }    
            }else if(sum + nums[j] > k){
                i++;
                sum -= nums[i];
            }else if(sum + nums[j] == k){
                totalNumOfSubArrays +=1;
                i++;
                j++;
                sum=0;
            }
        }
        return totalNumOfSubArrays;
    }
    }
}