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
        public void AddLast(int element){
            Node n  = new Node(element);
            if(IsEmpty()){
                Head = n;
                Tail = n;
                Size+=1;
            }else{
                Node tail = Tail;
                tail.Next = n;
                n.Previous=Tail;
                Tail = n;
                Size+=1;
            }

        }
        public void AddAtStart(int element){
            Node n = new Node(element);
            if(IsEmpty()){
                Head = n ; 
                Tail = n;
                Size+=1;
            }
            else{
                Node head = Head;
                Head = n;
                Head.Next = head;
            }
        }

       public void InsertAtIndex(int element, int index){
    Node n = new Node(element);
    
    if(index > Size){
        Console.WriteLine("The index currently does not exist so please use AddLast or AddAtfirst Method");
        return;
    }
    
    if(index == 0){
        // Inserting at the beginning
        n.Next = Head;
        if (Head != null)
            Head.Previous = n;
        Head = n;
        if (Size == 0)
            Tail = n;
        Size++;
        return;
    }
    
    Node current = Head;
    int i = 0;
    
    while(current != null){
        if(i == index - 1){
            // Inserting in between
            n.Previous = current;
            n.Next = current.Next;
            if (current.Next != null)
                current.Next.Previous = n;
            current.Next = n;
            Size++;
            if (n.Next == null)
                Tail = n;
            return;
        }
        current = current.Next;
        i++;
    }
}

public void RemoveLast(){
    if(IsEmpty()){
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("The list is empty");
        return;
    }
    if(Size == 1){
        Head = null;
        Tail = null;
        Size = 0;
        return;
    }
    //so we have last node as tail 
    Node new_tail = Tail.Previous;
    new_tail.Next = null;
    Size-=1;
    Tail = new_tail;
}
 public void DisplayNodes(){
            if(Head == null){
                Console.WriteLine("List is Currently empty");
                return;
            }
            Node n = Head;
            while(n!=null){
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Element => {n.Element}");
                n = n.Next;
            }
            Console.WriteLine($"Head is {Head.Element}");
            Console.WriteLine($"Tail is {Tail.Element}");
        }
        public bool IsEmpty(){
            return Size ==0;
        }
    }
}