using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05_OOP.Interface_Examble02
{
    //    internal class AirPlan : Vehicle, IMoveOnGround, IMoveOnAir
    //    {
    //        //Implement Implictly
    //        public void Backward()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void Forward()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void Left()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void Right()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        void IMoveOnGround.Backward()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        void IMoveOnGround.Forward()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        void IMoveOnGround.Left()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        void IMoveOnGround.Right()
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    internal class AirPlan : Vehicle, IMoveOnGround, IMoveOnAir
    {
        //Implement Explictly
        //Methods That Implemented Expliicity Can not be non-private
        void IMoveOnGround.Backward()//public [invalid]
        {
            Console.WriteLine("Airplane move backward on Ground");
        }

        void IMoveOnAir.Backward()
        {
            Console.WriteLine("Airplane move backward on air ");
        }

        

       public void Forward()
        {
            Console.WriteLine("Airplane move Forward");
        }

        void IMoveOnGround.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveOnAir.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveOnGround.Right()
        {
            throw new NotImplementedException();
        }

        void IMoveOnAir.Right()
        {
            throw new NotImplementedException();
        }
    }
}
