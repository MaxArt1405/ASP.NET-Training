using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    { 
   
        private Knot<T> _root;
        private IComparer<T> _comparer;


        public BinarySearchTree(){}
        public BinarySearchTree(IComparer<T> comparer)
        {
            _comparer = comparer ?? throw new ArgumentNullException($"The {nameof(comparer)} is null");
        }
        public BinarySearchTree(IComparer<T> comparer, IEnumerable<T> collection)
        {
            _comparer = comparer ?? throw new ArgumentNullException($"The {nameof(comparer)} is null");

            foreach (var i in collection)
            {
                Add(i);
            }
        }

        public void Add(T value) { }
        public void Remove(T value){ }

        private int Count { get; set; }

        private bool IsEmpty => Count == 0;
    }
}
