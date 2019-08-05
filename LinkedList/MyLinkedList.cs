public class MyLinkedList
    {
         public class Node
        {
            public int Value;

            public Node next;
            public Node(int value)
            {
                Value = value;
            }   
        }
        public Node head { get; set; }

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            this.head = null;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (head == null)
            {
                return -1;
            }
            int count = 0;
            Node temp = head;
            head = temp;
            while (temp != null)
            {
                if (index == count)
                {
                    return temp.Value;
                }
                count++;
                temp = temp.next;
            }

            return -1;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node newNode = new Node(val);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var prev = head;
                head = newNode;
                head.next = prev;
            }
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            Node newNode = new Node(val);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }

        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
         public void AddAtIndex(int index, int val)
        {
            index = index < 0 ? 0 : index; 
            if (head == null && index == 0)
            {
                var node = new Node(val);
                head = node;

            }
            else
            {
                if (head != null)
                {
                        if (index == 0)
                        {
                            AddAtHead(val);
                        }
                        else
                        {
                            Node iterate = head;
                            Node currentNode = head;
                            int count = 0;
                            while (count < index && iterate != null)
                            {
                                currentNode = iterate;
                                iterate = iterate.next;
                                count++;
                            }
                            currentNode.next = new Node(val);
                            currentNode.next.next = iterate;
                        }
                       


                }
            }



        }
        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index == 0 )
            {
                head = head.next;
            }
            else if (index > 0)
            {
                Node currentNode = head;
                Node iterate = head;
                int count = 0;
                while (count < index && iterate != null)
                {
                    currentNode = iterate;
                    iterate = iterate.next;
                    count++;
                }
                if (count == index)
                {
                    currentNode.next = iterate == null ? null : iterate.next;
                }
            }
            else
            {
                
            }
            
        }
    }
