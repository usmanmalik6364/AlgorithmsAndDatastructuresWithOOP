namespace ProgrammingQuestions
{
    using System;


    public class Exercise
    {
        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };
    
            List<string> result = words;
            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }
    
    //your code goes here
    public class StringsProcessor{
        public virtual List<string> Process(List<string> result){
            return result;
        }
    }
    public class StringsUppercaseProcessor : StringsProcessor{
        public override List<string>  Process(List<string>  result){
            var x =  result.Select(s => s.ToUpper()).ToList();
            return x;
        } 
    }
    public class StringsTrimmingProcessor : StringsProcessor{
        public override List<string>  Process(List<string> result){
            // return result.Substring(0,result.length/2)
            var TrimmedString = new List<string>();
            foreach (var s in result){
                TrimmedString.Add(s.Substring(0,s.Count()/2));
            }
            return TrimmedString;
        } 
    }
}
