using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeAPI
{
    /// <summary>
    /// Ağaç sınıfı
    /// </summary>
    public class Tree<T>
    {
        private Node<T> root;
        /// <summary>
        /// Kök düğüm
        /// </summary>
        public Node<T> Root
        {
            get { return root; }
            set { root = value; }
        }

        /// <summary>
        /// Kurucu metod - Constructor
        /// </summary>
        /// <param name="rootValue"></param>
        public Tree(T rootValue)
        {
            this.Root = new Node<T>(rootValue);
        }

        public string Print()
        {
            return this.Root.Print();
        }
    }
}
