using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Knot<T>
    {
        public Knot(Knot<T> left, Knot<T> rigth, T value)
        {
            Left = left;
            Rigth = rigth;
            Value = value;
        }

        public Knot<T> Left { get; set; }

        public Knot<T> Rigth { get; set; }

        public T Value { get; set; }
    }
}
