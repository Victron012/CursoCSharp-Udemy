using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Maria", "Bob", "Alex" };

            foreach(string s in vetor)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("------------------------------------");
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
