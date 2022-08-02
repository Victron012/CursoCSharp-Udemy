using System;

namespace Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine("Triple: "+triple);
            Console.WriteLine("A: "+a);
        }
    }
}
