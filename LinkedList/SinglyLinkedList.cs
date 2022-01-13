namespace LinkedList
{
    public class SinglyLinkedList
    {
        private Node _firstNode;

        public bool IsEmpty()
        {
            return _firstNode == null;
        }

        public void InsertFist(int data)
        {
            Node node = new();
            node.data = data;
            node.next = _firstNode;
            _firstNode = node;
        }

        public Node DeleteFirstNode()
        {
            Node tmep = _firstNode;
            _firstNode = _firstNode.next;
            return tmep;
        }

        public void DisplayList()
        {
            var current = _firstNode;
            while (current != null)
            {
                current.Display();
                current = current.next;
            }
        }

        public void InsertLast(int data)
        {
            var current = _firstNode;
            while (current.next != null)
            {
                current = current.next;
            }

            Node newNode = new();
            newNode.data = data;
            current.next = newNode;
        }
    }
}
