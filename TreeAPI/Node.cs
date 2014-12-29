using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeAPI
{
    /// <summary>
    /// Ağaç düğümü
    /// </summary>
    /// <typeparam name="ItemType"></typeparam>
    public class Node<T>
    {
        private T value;
        /// <summary>
        /// Düğümün değeri
        /// </summary>
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        private Node<T> parentNode;
        /// <summary>
        /// Düğümün baplı olduğu üst düğüm
        /// </summary>
        public Node<T> Parent
        {
            get { return parentNode; }
            set { parentNode = value; }
        }

        private List<Node<T>> childs;
        /// <summary>
        /// Düğüme bağlı alt düğümler listesi
        /// </summary>
        public List<Node<T>> Childs
        {
            get { return childs; }
        }

        /// <summary>
        /// Kurucu metod - Constructor
        /// </summary>
        /// <param name="value"></param>
        public Node(T value)
        {
            this.Value = value;
            this.childs = new List<Node<T>>();
        }

        /// <summary>
        /// Düğüme yeni alt düğüm ekleme
        /// </summary>
        /// <param name="subNode"></param>
        public void Add(Node<T> subNode)
        {
            subNode.Parent = this;
            this.Childs.Add(subNode);
        }

        /// <summary>
        /// Düğüme yeni alt düğüm ekleme (değer ile)
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            Node<T> subNode = new Node<T>(value);
            this.Add(subNode);
        }

        public Node<T> Branch(T value)
        {
            foreach (var subNode in this.Childs)
                if (subNode.Value.Equals(value))
                    return subNode;

            return null;
        }

        /// <summary>
        /// Düğümün alt düğümleri arasında aranılan değerde düğüm mevcut mu?
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(T value)
        {
            foreach (var subNode in this.Childs)
                if (subNode.Value.Equals(value))
                    return true;

            return false;
        }

        public string Print()
        {
            string result = string.Empty;
            result += this.Value.ToString() + "\n";

            foreach (var subNode in this.Childs)
                result += subNode.Print();

            return result;
        }
    }
}
