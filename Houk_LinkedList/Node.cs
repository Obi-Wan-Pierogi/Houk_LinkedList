namespace Houk_LinkedList
{
    internal class Node
    {
        public string Data { get; set; }
        public Node Next;
        public Node(string data)
        {
            Data = data;
        }
        public Node(string data, Node next)
        {
            Data = data;
            Next = next;
        }
    }
}
