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

LinkedList list = new LinkedList();
Node n = new Node(0);
Node n1 = new Node(1,null,n);
Node n2 = new Node(2,null,n1);
n.Next = n1;
n1.Next = n2;

list.AddNode(n);
list.AddNode(n1);
list.AddNode(n2);
list.DisplayNodes();