namespace ProgrammingQuestions
{
    public class LongestSubString
    {
        public int checkLongestSubString(string s){
            var characterDict = new Dictionary<char,char>();
            var longestSubStringCount = 0;
            foreach (char c in s){
                if(!characterDict.ContainsKey(c)){
                    characterDict.Add(c,c);
                    longestSubStringCount +=1;
                }else{
                    // longestSubStringCount = 0;
                }   
            }
            return longestSubStringCount;
        }
        public int checkLongestSubStringWithRepeatingCharacters(string s){
            var characterStack = new Stack<char>();
            var longestSubStringCount = 0;
            for (int i = 0; i < s.Length;i++){
                var c = s[i];
                if(characterStack.Count==0 || characterStack.Last()!=c)
                    {
                        characterStack.Append(c);
                        longestSubStringCount+=1;
                    }  
            }
            return longestSubStringCount;
        }
        
    }
}