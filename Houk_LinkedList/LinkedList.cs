namespace Houk_LinkedList
{
    internal class LinkedList
    {
        private Node _head;
        public void Add(string payload)
        {
            Node newNode = new Node(payload);
            
            if (_head == null || String.Compare(_head.Data,newNode.Data,ignoreCase:true) > 0)
            {
                newNode.Next = _head;
                _head = newNode;
            }
            else
            {
                Node current = _head;
                while (current.Next != null && String.Compare(current.Next.Data,newNode.Data, ignoreCase:true) <0)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }
        public bool Contains(string payload)
        {
            Node newNode = new Node(payload);
            Node current = _head;
            while (current != null)
            {
                if (String.Compare(current.Data, newNode.Data, ignoreCase: true) == 0)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public bool Remove(string payload)
        {
            // Variables to track nodes
            Node current = _head;
            Node previous = null;
            Node newNode = new Node(payload);
            while (current != null)
            {
                if (String.Compare(current.Data, newNode.Data, ignoreCase:true) == 0 )
                {
                    if (current == _head)
                    {
                        _head = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
        public void PrintAllNodes()
        {
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
