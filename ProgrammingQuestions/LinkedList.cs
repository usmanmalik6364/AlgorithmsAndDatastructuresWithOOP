namespace ProgrammingQuestions
{
    public class Node{
        public Node Next {get;set;}
        public Node Previous {get;set;}
        public int Element;
        public Node(int element, Node next =null, Node previous = null)
        {
            this.Element = element;
            this.Previous = previous;
            this.Next = next;
        }
    }
    public class LinkedList
    {
        public int Size = 0;
        public Node Head;
        public Node Tail;
        public void AddNode (Node n){
            if(IsEmpty()){
                Head = n;
            }
            Tail = n;
            Size+=1;
        }
        public void DisplayNodes(){
            Node n = Head;
            while(n!=null){
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Element => {n.Element}");
                n = n.Next;
            }
        }
        public bool IsEmpty(){
            return Size ==0;
        }
    }
}