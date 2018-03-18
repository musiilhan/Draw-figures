using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Butterfly:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("  Butterfly");
            int n = 5;
            int chertichki = n - 2;
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0}\\ /{0}", new string('*', chertichki));
                else
                    Console.WriteLine("{0}\\ /{0}", new string('-', chertichki));
            }
            Console.WriteLine("{0}@{0}", new string(' ', chertichki + 1));
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0}/ \\{0}", new string('*', chertichki));
                else
                    Console.WriteLine("{0}/ \\{0}", new string('-', chertichki));
            }
            Console.WriteLine();
        }
    }
}
