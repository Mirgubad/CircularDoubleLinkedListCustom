using System;
using System.Collections;

namespace LinkedLinkCustom
{
    public class MyDoubleLinkedList<T> : IEnumerable 
    {
        internal int Count;
        internal Node<T> Head;
        public Node<T> First { get; }
        public Node<T> Last { get; }

       

        public Node<T> AddFirst(T value)
        {
            if (Head == null)
            {
                var newNode = new Node<T> { Value = value };
                Head = newNode;
                Count++;
                return newNode;
            }
            else
            {
                var oldHead = Head;
                var newNode = new Node<T> { Value = value, Next = oldHead };
                Head = newNode;
                oldHead.Previous = Head;
                Count++;
                return Head;
            }
        }

        public IEnumerator GetEnumerator()
        {
            var node = Head;
            while (node != null)
            {
                yield return node.Value;

                node = node.Next;
            }
        }
        public Node<T> AddLast(T value)
        {
            var lastNode = Head;
            while (lastNode.Next != null)
            {
                lastNode = lastNode.Next;

            }
            var newNode = new Node<T> { Value = value, Previous = lastNode };
            lastNode.Next = newNode;
            Count++;
            return newNode;

        }
        public Node<T> AddAfter(Node<T> node, T value)
        {
            var newNode = new Node<T> { Value = value, Previous = node, Next = node.Next };
            node.Next.Previous = newNode;
            node.Next = newNode;
            Count++;
            return newNode;


        }
        public Node<T> AddBefore(Node<T> node, T value)
        {
            var newNode = new Node<T> { Value = value, Previous = node.Previous, Next = node };
            node.Previous.Next = newNode;
            node.Previous = newNode;
            Count++;
            return newNode;


        }
        public bool Remove(T value)
        {
            var node = Head;
            while (node != null)
            {
                if (node.Value.Equals(value))
                {
                    node.Next.Previous = node.Previous;
                    node.Previous.Next = node.Next;
                    Count--;
                    return true;
                }
                node = node.Next;
            }
            return false;
        }
        public void RemoveFirst()
        {
            Head = Head.Next;
            Count--;
            Head.Previous = null;
        }
        public void RemoveLast()
        {
            var lastNode = Head;
            while (lastNode.Next != null)
            {
                lastNode = lastNode.Next;


            }
            Count--;
            lastNode.Previous = null;

        }

        
    }



}
