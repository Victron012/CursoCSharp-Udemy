using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            //List<string> list2 = new List<string>() { "Maria", "Alex" };

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nlist.Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': "+s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': "+s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First index of 'A': "+pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last index of 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------------\nNomes com 5 caracteres: ");
            foreach(string s in list2)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------------------------");
            list.Remove("Alex");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------------------");
            list.RemoveAt(0);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------------------");
            list.RemoveAt(0);
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");
            list.RemoveRange(2, 2);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
