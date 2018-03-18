using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n= 0;
            do
            {
                Console.WriteLine("Like the drawings with strings?");
                Console.WriteLine("just press:");
                Console.WriteLine("1-Triangle");
                Console.WriteLine("2-Butterfly");
                Console.WriteLine("3-Flower");
                Console.WriteLine("4-House");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (n == 1)
                {
                    Shape a = new Triangle();
                    a.Draw();
                }
                else if (n == 2)
                {
                    Shape b = new Butterfly();
                    b.Draw();
                }
                else if (n == 3)
                {
                    Shape c = new Flower();
                    c.Draw();
                }
                else if (n == 4)
                {
                    Shape d = new House();
                    d.Draw();
                }
                else
                    Console.WriteLine("There is no drawing");
                Console.WriteLine();
            }
            while (n > 1 || n < 4);
           
        }
    }
}
