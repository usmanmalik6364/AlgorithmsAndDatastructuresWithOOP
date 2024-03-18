
using System.Drawing;

public class Stack{
    public int Size;
    public int[] Elements;

    public Stack(){
        Elements = new int[10];
    }
    public void AddElement(int[] nums){
         var findErrorNum = new Dictionary<int,int>();
        var result = new int[2];
        int i = 0;
        foreach(var num in nums){
            if(!findErrorNum.ContainsKey(num)){
                findErrorNum.Add(num,num);
            }else{
                //duplicate num
                //number not in sequence;
                // int numNotInSequence = 1;
                // if( i > 0 && !findErrorNum.ContainsKey(i)){
                //     numNotInSequence = i;
                // }
                result[0] = num;
                result[1] = i> 0 && findErrorNum.ContainsKey(i)? i+1:num+1;
                
            }
            i++;

        }
        Console.WriteLine($"{result[0]}{result[1]}");
    }
    
}