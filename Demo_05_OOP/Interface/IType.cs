using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05_OOP.Interface
{
    //Dev 01 
    internal interface IType
    {
        //1. Signature for property
        public int MyProperty { get; set; }

        //2. Signature for methods

        public void MyMethod();

        // 3. Default Implemented Method [C# 08]

        public void Print()
        {
            Console.WriteLine("Hello from default implemented Method");

        }

    }
}
