using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Triangle:Shape
    {
        public override void Draw()
        {

            Console.WriteLine("  triangle");
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i));
            }
            Console.WriteLine();
        }
    }
}
