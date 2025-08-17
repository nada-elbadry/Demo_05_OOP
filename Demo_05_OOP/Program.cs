using Demo_05_OOP.Binding;

namespace Demo_05_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Binding

            //TypeA typeARef = new TypeB(1, 2);
            //typeARef.A = 10;
            //// typeARef. B =20; [INVALID]
            //typeARef.MyFun01();//Static Binding 
            //                   //Called Based on reference type
            //                   //I Am type A [Parent]

            //typeARef.MyFun02();//Dynamic Binding
            //                   // Calle Based On Object Type
            //                   //Type B : A = 1 , b = 2


            // TypeA typeARef = new TypeC(1,2,3);//TypeA Indirect Parent
            // typeARef.B =20; [INVALID]
            //typeARef.A = 10;
            //typeARef.C = 5; [INVALID]
            //typeARef.MyFun01();//I Am type A[Parent]
            // typeARef.MyFun02();//Type C : A = 1 , b = 2 c=3
            //Console.WriteLine("========================");
            // TypeB typeBRef = new TypeC(2,3,4);//TypeB Direct Parent
            // typeBRef.A = 1;
            // typeBRef.B = 2;
            //typeBRef.c =3; //Invalid
            // typeBRef.MyFun01();//I Am TypeB [child]
            // typeBRef.MyFun02();// TypeC a = 10 , b = 20 , c=3


           // typeCRef.MyFun02();//// Type C : A = 1 , b = 2 c=3
                               // TypeA typeARef = new TypeD(1, 2, 3, 4); //Indirect Parent
                               // typeARef.MyFun01();//Static Binding
                               // typeARef.MyFun02();// Dynamic Binding [Type C : A = 1 , b = 2 c=3]
                               //
                               // TypeB typeBRef = new TypeD(1,2,3,4);//Indirect Parent
                               // typeBRef.MyFun01();//I am Type B [Child]
                               // typeBRef.MyFun02();// Type C : A = 1 , b = 2 c=3
                               //
                               // TypeC typeCRef = new TypeD(1,2,3,5);//Direct Parent
                               // typeCRef.MyFun01();// I Am Type C [Grand Child]

           // TypeA typeARef = new TypeE(1, 2, 3, 4, 5);//Indirect parent
           // TypeB typeBRef = new TypeE(1,2,3,4,5);//Indirect parent
           // TypeC typeCRef = new TypeE(1,2,3,4,5);//Indirect parent
           // TypeD typeDRef = new TypeE(1,2,3,4,5);//direct parent
           //
           // typeARef.MyFun02();//Type C : A = 1 , b = 2 c=3
           // typeBRef.MyFun02();//Type C : A = 1 , b = 2 c=3
           // typeCRef.MyFun02();//Type C : A = 1 , b = 2 c=3
           // typeDRef.MyFun02();//Type E :  A = 1 , b = 2 c=3 d=4 E =5
           //==============
            #endregion
        }
    }
}
