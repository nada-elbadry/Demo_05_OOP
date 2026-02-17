using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05_OOP.Binding
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int a)
        {
            a = A;
        }
        //static polymarphism
        public void  MyFun01()
        {
            Console.WriteLine("I Am Type A [Base]");
        }
        //Dynamic Polymarphism
        public virtual void MyFun02() 
        {
            Console.WriteLine($"Type A : A={A} ");
        
        }
    }
}
