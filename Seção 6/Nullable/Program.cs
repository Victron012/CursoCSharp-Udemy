using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) { Console.WriteLine(x.Value); }
            else { Console.WriteLine("X is null"); }
            
            if (y.HasValue) { Console.WriteLine(y.Value); }
            else { Console.WriteLine("Y is null"); }


            // operador de coalescencia nula
            Console.WriteLine("operador de coalescencia nula");
            double? X = null;
            double? Y = 10;
            double a = X ?? 5;
            double b = Y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
            
        }
    }
}
