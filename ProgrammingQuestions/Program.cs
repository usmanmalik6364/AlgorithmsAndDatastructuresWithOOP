// See https://aka.ms/new-console-template for more information
using System.Xml.XPath;
using ProgrammingQuestions;

// LongestSubString s = new LongestSubString();
// var r = s.checkLongestSubString("pwwkew");
// Console.WriteLine(r);


// calculateFibSeries();
// TestTwoSum();


// static void calculateFibSeries(){
//     FibonacciSeries f = new FibonacciSeries(111111150); 
//     f.printFibSeries();
// }

// static void TestTwoSum(){
//     TwoSum test = new TwoSum();
//     int[] s  = new int[4];
//     s[0]=1;
//     s[1]=3;
//     s[2]=4;
//     s[3]=2;
//     var result = test.TwoSumM(s,6);
//     Console.WriteLine(result[0] + "\t" +result[1]);
// }

// LinkedList list = new LinkedList();
// list.AddLast(0);
// list.AddLast(1);
// list.AddLast(2);
// list.AddLast(4);
// list.InsertAtIndex(3,3);
// list.RemoveLast();
// list.DisplayNodes();

// findDupNumAndMissing();
//  void findDupNumAndMissing(){
//          int[] nums = new int[3];
//          nums[0]=3;
//          nums[1]=2;
//          nums[2]=2;

         
//          var findErrorNum = new Dictionary<int,int>();
//         var result = new int[2];
//         foreach(var num in nums){
//             if(!findErrorNum.ContainsKey(num)){
//                 findErrorNum.Add(num,num);
//             }else{
//                 result[0] = num;   
//             }
//         }
//         for(int i = 1; i<nums.Length;i++){
//             if(!findErrorNum.ContainsKey(i)){
//                 result[1]=i;
//             }
//         }
//         Console.WriteLine($"{result[0]}{result[1]}");

//         int [] arr = new int[2];
       
//     }

// var nums = new int[] { 3,2,1,0,4 };
// Console.WriteLine(CanJump(nums));
//   bool CanJump(int[] nums) {
//         bool canJump = false;
//         for(int i = 0 ; i < nums.Length;i++){
//             if(nums[i]==0 && i<nums.Length-1)
//                 {
//                     canJump= false;
//                     break;
//                 }
//             else{
//                 i+=nums[i];
//             }
//             if(i==nums.Length-1){
//                 canJump = true;
//             }
            
//         }
//         return canJump;
//     }



// var binarySearch = new BinarySearch();
// var arr = new int[]{1,2,3,4,5,6,700,800,900,100000};
// var index = binarySearch.BinarySearchOnArray(arr,800);
// Console.WriteLine($"Index is {index}" );


var SelectionSort = new SelectionSort();
var arr = new int[]{10,4,23,2,32,32,3};
var new_arr = SelectionSort.Sort(arr);
foreach(var num in new_arr){
    Console.WriteLine($"Num => {num}");
}