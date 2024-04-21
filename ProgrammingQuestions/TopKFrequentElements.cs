namespace ProgrammingQuestions
{
    public static class TopKFrequentElements
    {
        public static int[] TopKFrequent(int[] nums, int k) {
        //map for storing frequencies
        Dictionary<int,int> map = new Dictionary<int,int>();
        List<int> results = new List<int>();
        for(int i = 0 ; i< nums.Length;i++){
            if(!map.ContainsKey(nums[i]))
                map.Add(nums[i] , 1);
            else{
                map[nums[i]] = map[nums[i]]+ 1;
            }
        }
        foreach (KeyValuePair<int,int> kvp in map){
            //first is the number, second is frequency
            var occurence = kvp.Value;
            if(occurence >= k){
                results.Add(kvp.Key);
            }
        }
        return results.ToArray();
        }
    }
}