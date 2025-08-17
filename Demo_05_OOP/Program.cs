//using Demo_05_OOP.Binding;
using Demo_05_OOP.Interface;
using Demo_05_OOP.Interface_Examble01;
using Demo_05_OOP.Interface_Examble02;
using System.Text;
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

            //TypeB typeBObj = new TypeB();
            //PrintFiveNumberFromSeries(typeBObj);

            // TypeC typeCObj = new TypeC();
            // PrintFiveNumberFromSeries(typeCObj);//Invalid

            #endregion

            #region Examble 02

            //Car carObj = new Car();
            //carObj.Speed = 500;
            //carObj.Forward();
            //carObj.Backward();
            //carObj.Left();
            //carObj.Right();

            //  AirPlan airPlanObj = new AirPlan();
            // airPlanObj.Speed = 200;
            //airPlanObj.Forward();//Airplan Move Forward Implemented Implicity
            //airPlanObj.Backward();//Invalid [Implemented Explicitly]
            // airPlanObj.Left();//Invalid [Implemented Explicitly]
            // airPlanObj.Right();//Invalid [Implemented Explicitly]

            // IMoveOnAir moveAirPlanOnAir= new AirPlan();
            // moveAirPlanOnAir.Speed = 100;//Invalid
            //moveAirPlanOnAir.Forward();
            //moveAirPlanOnAir.Backward();//Valid

            //IMoveOnGround moveAirplanOnGround = new AirPlan();
            //moveAirplanOnGround.Forward();
            //moveAirplanOnGround.Backward();
            //moveAirplanOnGround.Left();
            //moveAirplanOnGround.Right();
            #endregion

            #region Shallow Copy and Deep Copy

            #region Array of value type
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];//{0,0,0}
            //Console.WriteLine($"HashCode Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Arr02 = {Arr02.GetHashCode()}");

            #region Shallow Copy
            // Arr02 = Arr01;//Shallow Copy 
            //Copy Value of Arr01 To Arr02
            //value=Adress
            //Copy Happend in stack
            //[ Arr01 , Arr02 ]=> Has Same [Adress]
            //[ Arr01 , Arr02 ]=> Refer To The Same Object
            //Console.WriteLine("Shallow Copy");
            //Console.WriteLine($"HashCode Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Arr02 = {Arr02.GetHashCode()}");
            //Arr01[0] = 100;
            //Console.WriteLine($"Arr01[0]={Arr01[0]}");
            //Console.WriteLine($"Arr02[0]={Arr02[0]}");
            #endregion

            #region Deep Copy

            // Arr02 = (int[])Arr01.Clone();//Deep Copy
            // Make a new array which is a shallow copy of the original array.
            //Happend In Heap
            //Crate New Object With Diffrent And New Identity And Return It
            //The New Object Will Have The Same Object  State [Data] Of Caller 'Arr01'

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of Arr02 = {Arr02.GetHashCode()}");
            //Arr01[0] = 100;
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");//100
            //Console.WriteLine($"Arr02[0] = {Arr01[0]}");//1

            #endregion


            #endregion

            #region Array Of Reference Type

            #region Immutable Type 
            //strings , custom immutable type
            //string[] Names01 = {"Omar","Amr"};//{RefString01,RefString02}
            //string[] Names02 = new string[2];//{null,null}
            //Console.WriteLine($"HashCode of Name01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of Name02 = {Names02.GetHashCode()}");

            #region Shallow Copy [Copy Identity]
            //Names02 = Names01;
            //Copy Value Of Names01 To Names02
            //Coppy Happend In Stack
            //[Names01,Names02] => Has Same Value [Adress]
            ////[Names01,Names02] =>Refer To The Same Object
            //Console.WriteLine("After Shallow copy");
            //Console.WriteLine($"HashCode of Name01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of Name02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] ={Names01[0]}");//omar
            //Console.WriteLine($"Names02[0] ={Names02[0]}");//omar

            //Names01[0] = "Sama";

            //Console.WriteLine($"Names01[0] ={Names01[0]}");//sama
            //Console.WriteLine($"Names02[0] ={Names02[0]}");//sama
            #endregion

            #region Deep Copy

            //Names01 = (string[])Names01.Clone();//Coppy Happend In Heap
            //Create New Object With Diffrent and new identity with the same object state of caller 'name01'
            //Return it
            //[Name01,Names02]=>Are Refaring To Diffrent Object
            //Console.WriteLine("After Deep copy");
            //Console.WriteLine($"HashCode of Name01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of Name02 = {Names02.GetHashCode()}");

            //Names01[0] = "Abeer";
            //Console.WriteLine($"Names01[0] ={Names01[0]}");//Abeer
            //Console.WriteLine($"Names02[0] ={Names02[0]}");//omar

            #endregion

            #endregion

            #region Mutable Type
            //string Builder /list
           // StringBuilder[] Names01 = new StringBuilder[1];
            //=> {null}
            // Names01[0] = "omar";//invalid
            //  Names01[0].Append("Omar");//invalid 

            //Names01[0] = new StringBuilder("omar");

            //StringBuilder[] Names01 = [new StringBuilder("omar")];//collection exeperision

            //StringBuilder[] Names02 = new StringBuilder[1];
            //Console.WriteLine($"HashCode of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of Names02 = {Names02.GetHashCode()}");

            #region Shallow Copy
            // Names01 = Names02;
            //Names01 , Names02 => Refer to the same object
            //Copy adress
            //Console.WriteLine("After shallow copy");
            //Console.WriteLine($"HashCode of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] ={Names01[0]}");//omar
            //Console.WriteLine($"Names02[0] ={Names02[0]}");//omar

            //Names01[0].Append("Ahmed");
            //Console.WriteLine($"Names01[0] ={Names01[0]}");//omar Ahmed
            //Console.WriteLine($"Names02[0] ={Names02[0]}");//omar Ahmed
            #endregion

            #region Deep Copy
           // Names02 = (StringBuilder[])Names01.Clone();
            // Create new object diffrent and new identity with the same object state of caller 'Name02'
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode of Names01 = {Names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of Names02 = {Names02.GetHashCode()}");

            //Console.WriteLine($"Names01[0] ={Names01[0]}");//omar
            //Console.WriteLine($"Names02[0] ={Names02[0]}");//omar

            //Names01[0].Append("Ahmed");
            //Console.WriteLine("After Changing ");
            //Console.WriteLine($"Names01[0] ={Names01[0]}");//omar Ahmed
            //Console.WriteLine($"Names02[0] ={Names02[0]}");//omar Ahmed
            #endregion

            #endregion

            #endregion

            #endregion
        }
    }
}
