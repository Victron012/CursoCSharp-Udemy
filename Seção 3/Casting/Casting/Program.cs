using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;
            int z = (int)y; //casting
            
            Console.WriteLine(y);

            x = (float)y; //casting

            Console.WriteLine(x);

            Console.WriteLine(z);

            int a = 5;
            int b = 2;
            double res = (double)a / b;

            Console.WriteLine(res);

        }
    }
}
