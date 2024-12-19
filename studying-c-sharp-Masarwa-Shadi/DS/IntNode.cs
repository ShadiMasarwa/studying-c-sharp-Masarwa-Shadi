using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS
{
    public class IntNode
    {
            private int value;
            private IntNode next;

            public IntNode(int value)
            {
                this.value = value;
                this.next = null;
            }

            public IntNode(int value, IntNode next)
            {
                this.value = value;
                this.next = next;
            }

            public int GetValue()
            {
                return this.value;
            }

            public IntNode GetNext()
            {
                return this.next;
            }

            public bool HasNext()
            {
                return (this.next != null);
            }

            public void SetValue(int value)
            {
                this.value = value;
            }

            public void SetNext(IntNode next)
            {
                this.next = next;
            }

            public override string ToString()
            {
                return value + " ";
            }

            // This method was added to use for printing list

            public string ToPrint()
            {
                if (this == null)
                    return "null";

                if (this.HasNext())
                    return value + ", " + this.next.ToPrint();
                return value + ", null";
            }
        }
    }
