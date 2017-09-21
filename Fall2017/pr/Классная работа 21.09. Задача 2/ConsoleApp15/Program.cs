using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y= int.Parse(Console.ReadLine());
            int z= int.Parse(Console.ReadLine());
            if ((x>y)&(y>z))
            {
                Console.WriteLine(z);
                Console.WriteLine(y);
                Console.WriteLine(x);
            }
            else if ((x>z) &(z>y))
            {
                Console.WriteLine(y);
                Console.WriteLine(z);
                Console.WriteLine(x);
            }
            else if ((y > x) & (x > z))
            {
                Console.WriteLine(z);
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            else if ((y > z) & (z > x))
            {
                Console.WriteLine(x);
                Console.WriteLine(z);
                Console.WriteLine(y);
            }
            else if ((z > x) & (x > y))
            {
                Console.WriteLine(y);
                Console.WriteLine(x);
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
            }
        }
        
    }
}
