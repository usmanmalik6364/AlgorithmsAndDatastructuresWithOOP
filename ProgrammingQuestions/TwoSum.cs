namespace ProgrammingQuestions
{
    public static class TwoSum
    {
         public static int[] TwoSumM(int[] nums, int target) {
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
        public static int[] TwoSumUsingOOfNComplex(int[] nums, int target) {
            Dictionary <int,int> map = new Dictionary<int,int>();
            //write down equation which is x = target - current
            for(int i = 0 ; i < nums.Length;i++){
                var current = nums[i];
                var x = target - current;
                if(map.ContainsKey(current)){
                    //C# 12 featue return[map[current], i];
                    var resultArr = new int[]{map[current],i};
                    return resultArr;
                }
                else{

                }
            }
            return null;
            }
    }
}