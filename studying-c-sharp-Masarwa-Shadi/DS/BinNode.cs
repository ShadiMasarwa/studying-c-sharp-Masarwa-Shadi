using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS
{
    public class BinNode<T>
    {
        private T value;
        private BinNode<T> left;
        private BinNode<T> right;

        //-----------------------------------
        // constructors
        public BinNode(T value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
        public BinNode(BinNode<T> left, T value, BinNode<T> right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
        //-----------------------------------
        // Getters
        public T GetValue()
        {
            return value;
        }

        public BinNode<T> GetLeft()
        {
            return this.left;
        }
        public BinNode<T> GetRight()
        {
            return this.right;
        }
        //-----------------------------------
        // Setters
        public void SetValue(T value)
        {
            this.value = value;
        }
        public void SetLeft(BinNode<T> left)
        {
            this.left = left;
        }

        public void SetRight(BinNode<T> right)
        {
            this.right = right;
        }
        //-----------------------------------
        // returns true if this.left is not null, else returns false
        public bool HasLeft()
        {
            return (this.left != null);
        }
        // returns true if this.right is not null, else returns false
        public bool HasRight()
        {
            return (this.right != null);
        }
        //-----------------------------------
        //ToString
        public override string ToString()
        {
            return "(" + left + " " + value + " " + right + ")";
        }
    }
}
