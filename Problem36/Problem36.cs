using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem36
{
    class A
    {
        public int num = 1;
        public virtual void Display()
        {
            Console.WriteLine(num);
        }
    }
    class B : A
    {
        private int num = 5;

        public override void Display()
        {
            Console.WriteLine(num);
        }
    }

    class C : B
    {
        private int num = 2;
        public void Display()
        {
            Console.WriteLine(num);
        }
    }

    class D : C
    {
        public void Display()
        {
            Console.WriteLine(num);
        }
    }
     

    public class Class36
    {
        public static void Problem36()
        {
            A MyA = new A();
            B MyB = new B();
            C MyC = new C();
            D MyD = new D();

            Console.Write($"\n Class A contains:");
            MyA.Display();
            Console.Write($"\n Class A's variable in class B is ");
            MyB.Display();
            Console.Write($"\n Class A's variable in class C is ");
            MyC.Display();
            Console.Write($"\n Class A's variable in class D is ");
            MyD.Display();
        }
    }

}
