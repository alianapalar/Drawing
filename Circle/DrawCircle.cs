using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class DrawCircle
    {
        public static void Circle(int radius) 
        {
            for (double i = -radius; i <=radius; i++)
            {
                for (double j =-radius; j < radius; j+=0.5)
                {
                    if ((i * i) + (j * j) <= radius * radius)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
    }
}
