namespace CustomLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customLinkedList List = new customLinkedList();
            List.AddFirst(6);
            List.AddFirst(3);
            List.InsertAfter(6, 1);
            List.Print();
            
        }
    }
}