using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05_OOP.Interface_Examble02
{
    internal class Car : Vehicle, IMoveOnGround
    {
        public void Backward()
        {
            Console.WriteLine("Move Car Backward");
        }

        public void Forward()
        {
            Console.WriteLine("Move Car Forward");
        }

        public void Left()
        {
            Console.WriteLine("Move Car Left");
        }

        public void Right()
        {
            Console.WriteLine("Move Car Right");
        }
    }
}
