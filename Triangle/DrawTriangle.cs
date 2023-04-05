using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class DrawTriangle
    {
        public static void Triangle(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
