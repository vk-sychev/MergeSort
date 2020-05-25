using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Elem
    {
        public int Value { get; set; }
        public bool EndOfSubSequence { get; set; }
        public Elem(int value)
        {
            this.Value = value;
            this.EndOfSubSequence = false;
        }
    }
}
