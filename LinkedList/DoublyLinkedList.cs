namespace HackerEarth.LinkedList
{
    class Node
    {
        public Node prev = null;
        public Node next = null;
        public int data = -1;
        public Node()
        { }
        public Node(int val)
        {
            data = val;
        }
        public Node add(int val)
        {
            //Initialize head
            if (this.data == -1)
            {
                this.data = val;
                return this;
            }
            Node node = this;
            Node n = new Node(val);
            while (node.next != null)
            {
                node = node.next;   
            }
            node.next = n;
            n.prev = node;
            n.next = null;
            return n;
        }
        public Node remove(int val)
        {
            Node node = this;
            while (node.next != null)
            {
                if (node.data == val)
                {
                    Node cur = node;
                    Node prev = cur.prev;
                    Node next = cur.next;

                    if (prev != null)
                        prev.next = next;

                    next.prev = prev;
                }
                node = node.next;
            }
            return node;
        }
    }
}