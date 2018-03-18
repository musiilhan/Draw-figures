using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Flower:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Flower");
            int n = 5;
            int ins = 0;
            int mid = n * 2;
            int mid2 = 0;
            int insDot = n * 2;
            int autDot = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~', ins), new string('.', mid), new string('.', mid2));
                ins++; mid -= 2; mid2 += 2;
            }
            ins = n;
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', autDot), new string('~', ins), new string('.', insDot));
                autDot += 2; ins--; insDot -= 2;
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}##{0}", new string('.', n * 2 + 2));
        }
    }
}
