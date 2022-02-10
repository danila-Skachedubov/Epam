using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    public class CycledDynamicArray<T>: DynamicArray<T>
    {
        public CycledDynamicArray(T[] array) : base(array) { }

        public class CycledClassNumerator : ClassNumerator
        {
            public CycledClassNumerator(T[] Array, int Length): base(Array, Length) { }

            public override bool MoveNext()
            {
                if (position == array.Length)
                    position = -1;

                position++;
                return true;
            }
        }
    }
}
