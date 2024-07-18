﻿namespace studying_c_sharp_Masarwa_Shadi.DS
{
    public class BinNode<T>
    {
        private T value;
        private BinNode<T> left;
        private BinNode<T> right;
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
        public BinNode<T> GetLeft()
        {
            return this.left;
        }
        public BinNode<T> GetRight()
        {
            return this.right;
        }
        public void SetLeft(BinNode<T> left)
        {
            this.left = left;
        }
        public void SetRight(BinNode<T> right)
        {
            this.right = right;
        }
        public T GetValue()
        {
            return this.value;
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public bool HasLeft()
        {
            return this.left != null;
        }
        public bool HasRight()
        {
            return this.right != null;
        }

        public BinNode<T> GetLast()
        {
            BinNode<T> binLst = this;
            while (binLst.HasRight())
                binLst = binLst.GetRight();
            return binLst;
        }
        public override string ToString()
        {
            return " " + this.value;
        }

        public string ToPrint()
        {
            if (this == null)
                return "null";

            if (this.HasRight())
                return value + ", " + this.GetRight().ToPrint();
            return value + ", null";
        }
    }

}
