//using Demo_05_OOP.Binding;
using Demo_05_OOP.Interface;
using Demo_05_OOP.Interface_Examble01;
using Type = Demo_05_OOP.Interface.Type;//Alias Name
//Or using full qalifay to choose whats Type you want to use here
namespace Demo_05_OOP
{
    internal class Program
    {
        public static void PrintFiveNumberFromSeries(ISeries? series)
        {
            if (series is not null)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"{series.Current}");
                    series.GetNext();

                }
                series.Reset();
            }
            else
            {
                return;

            }

        }
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

            #region Interface
            //  IType refType;
            //Declare For Reference From From Type 'Itype'
            //CLR Will Allocate 4 Bytes At Heap 
            //'refType' Can Refer To Any Type That Implement Interface 'IType'

            // refType=new IType();  //Invalid 

            // refType = new Demo_05_OOP.Interface.Type();
            //System.Type

            //refType = new Interface.Type();

            //refType.MyProperty = 50;
            //refType.MyMethod();// Hello from class Type
            //refType.Print();//Hello from default implemented Method

            //Type typeObj = new Type();
            //typeObj.MyProperty = 50;
            //typeObj.MyMethod();
            //typeObj.Print();//Invalid 
            #endregion

            #region Examble 01

            //TypeA typeAObj = new TypeA();
            //PrintFiveNumberFromSeries(typeAObj);

            TypeB typeBObj = new TypeB();
            PrintFiveNumberFromSeries(typeBObj);

           // TypeC typeCObj = new TypeC();
           // PrintFiveNumberFromSeries(typeCObj);//Invalid

            #endregion
        }
    }
}
