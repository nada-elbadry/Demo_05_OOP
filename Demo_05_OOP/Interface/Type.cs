using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05_OOP.Interface
{
    internal class Type : IType
    {
        public int MyProperty { get; set; }

        public void MyMethod()
        {
            Console.WriteLine("Hello from class Type ");
        }
    }
}
