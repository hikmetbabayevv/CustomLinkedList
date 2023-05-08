using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Node
    {
        public int Data;
        
        public Node Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class customLinkedList
    {
        Node _head;

        public Node First => _head;

        public Node Last
        {
            get
            {
                return GetLastNode();
            }
        }
        int _count;
        public int Count
        {
            get
            {
                if (_count < 0)
                {
                    _count = 0;
                }
                return _count;
            }
            private set
            {
                _count = value;
            }
        }
        public Node GetLastNode()
        {
            Node tmp = _head;
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
            }
            return tmp;

            
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            Count++;
            if (_head != null)
            {
                newNode.Next = _head;
            }
            _head = newNode;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            Count++;
            if (_head == null)
            {
                _head = newNode;
                return;
            }
            Node lastNode = GetLastNode();  
            lastNode.Next = newNode;
        }
        public Node Find(int data)
        {
            Node tmp = _head;
            while (tmp.Next != null)
            {
                if (tmp.Data == data)
                {
                    return tmp;
                }
                tmp = tmp.Next;
            }
            return null;
        }
        public void InsertAfter(int data,int index)
        {
            Node newNode = new Node(data);
            newNode.Next = null;
            if (index == 1)
            {
                newNode.Next = _head;
                _head = newNode;
            }
            else
            {
                Node tmp = _head;
                for (int i = 1; i < index - 1; i++)
                {
                    if ( tmp!= null)
                    {
                        tmp = tmp.Next;
                    }
                }
                if (tmp!= null)
                {
                    newNode.Next = tmp.Next;
                    tmp.Next = newNode;
                }
            }


        }
        public void Print()
        {
            Node tmp = _head;
            while (tmp.Next != null)
            {
                Console.WriteLine(tmp.Data);
                tmp = tmp.Next;
            }
            Console.WriteLine(tmp.Data);
        }

    }
}
