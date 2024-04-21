//Leetcode #49
namespace ProgrammingQuestions
{
    public static class GroupAnagrams{
    public static IList<IList<string>> GroupAnagramsQ(string[] strs) {
            IList<IList<string>> results = new List<IList<string>>();
            //Brute force approach 
            Dictionary<string,string[]> map = new Dictionary<string,string[]>();
            for ( int i = 0 ; i <strs.Length; i++){
            //second pointer for one more than the array 
            char[] charArr = new char[strs[i].Length];
            charArr = strs[i].ToArray();
            Array.Sort(charArr);
             string sortedStr = new string(charArr);
            if(!map.ContainsKey(sortedStr))
            {
                var s = new string[]{strs[i]};
                map.Add(sortedStr, s);
            }
            else{
                List<string> existingElements = map[sortedStr].ToList();
                existingElements.Add(strs[i]);
                map[sortedStr] = existingElements.ToArray();
            } 
        }
        foreach (KeyValuePair<string, string[]> kvp in map)
        {
            // Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                IList<string> list = kvp.Value.ToList();
                results.Add(list);
        }


            return results;
        }

        }
        
        
        }