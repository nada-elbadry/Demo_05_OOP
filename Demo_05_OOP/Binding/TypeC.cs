using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05_OOP.Binding
{
    internal class TypeC:TypeB
    {

        public int C { get; set; }

        public TypeC(int a , int b , int c):base(a,b)
        {
            C= c;
        }

        public new void MyFun01()
        {
            Console.WriteLine("I Am Type C [Grand Child]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"Type C : A = {A} , b = {B}  , c  ={C}");
        }
    }
}
