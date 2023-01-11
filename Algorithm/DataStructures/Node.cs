using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    internal class Node<T> : IComparable where T : IComparable
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public Node() { }
        public Node(T data)
        {
            if (data != null) Data = data;
            else throw new ArgumentNullException(nameof(data));
        }

        public void Add(T data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            var node = new Node<T>(data);
            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null) Left = node;
                else Left.Add(data);
            }
            else
            {
                if (Right == null) Right = node;
                else Right.Add(data);
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
                return Data.CompareTo(item);
            else
                throw new ArgumentException("Not a correct type");
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
