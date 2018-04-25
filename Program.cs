using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PacmanProject
{
    class Program
    {
        static void Main()
        {
        //bla bla bla
            var a = int.Parse(Console.ReadLine());
            Print(a);
        }

        public static void Print(int a)
        {
            if (a == 0)
            {
                Console.WriteLine(a);
                Console.ReadLine();
                return;
            }

            Console.WriteLine(a);
            Print(a-1);
        }
    }
}
