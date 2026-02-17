using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05_OOP.Interface_Examble01
{
    internal class TypeC
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 4;
        }
        public void Reset()
        {
            Current = 0;
        }
    }
}
