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
        public void ADisplay()
        {
            Console.WriteLine($"     Class A's variable is {num}\n");
        }
    }
    class B : A
    {
        private int numB = 5;

        public void BDisplay()
        {
            Console.WriteLine($"     Class A's variable is {num}");
            Console.WriteLine($"     Class B's variable is {numB}\n");
        }
    }

    public class Class36
    {
        public static void Problem36()
        {
            A MyA = new A();
            B MyB = new B();

            Console.WriteLine($"Class A contains:");
            MyA.ADisplay();
            Console.WriteLine($"Class B contains:");
            MyB.BDisplay();
        }
    }

}
