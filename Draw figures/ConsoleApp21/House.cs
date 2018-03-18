using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class House:Shape
    {
        public override void Draw()
        {
            
                int n = 10;
                var stars = 1;
                if (n % 2 == 0)
                    stars = 2;
                var tire = n / 2 - 1;
                Console.WriteLine("  House");
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write(new string('-', tire));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', tire));
                    Console.WriteLine();
                    stars += 2;
                    tire--;
                }
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.Write("|");
                    Console.WriteLine();
                }

                Console.WriteLine();
            
        }
    }
}
