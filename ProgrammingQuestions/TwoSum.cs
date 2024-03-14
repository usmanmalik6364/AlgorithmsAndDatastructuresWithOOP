namespace ProgrammingQuestions
{
    public class TwoSum
    {
         public int[] TwoSumM(int[] nums, int target) {
        var result =  new int[2];
        for(int i = 0 ; i < nums.Length;i++){
            for(int j = 1; j<nums.Length;j++){
                if(i!=j && nums[i]+ nums[j] == target){
                    result[0]=i;
                    result[1] = j;
                    break;
                }
            }
        }
        return result;
    }
    }
}