﻿using System;

namespace Date_Time_Kind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: "+d1);
            Console.WriteLine("di.Kind: "+d1.Kind);
            Console.WriteLine("d1.ToLocalTime: " + d1.ToLocalTime() );
            Console.WriteLine("d1.ToUniversalTime: " + d1.ToUniversalTime() );
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2.Kind: " + d2.Kind);
            Console.WriteLine("d2.ToLocalTime: " + d2.ToLocalTime());
            Console.WriteLine("d2.ToUniversalTime: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3.Kind: " + d3.Kind);
            Console.WriteLine("d3.ToLocalTime: " + d3.ToLocalTime());
            Console.WriteLine("d3.ToUniversalTime: " + d3.ToUniversalTime());

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z"); //formato 8601 LOCAL

            Console.WriteLine();
            Console.WriteLine("d4: " + d4);
            Console.WriteLine("d4.Kind: " + d4.Kind);
            Console.WriteLine("d4.ToLocalTime: " + d4.ToLocalTime());
            Console.WriteLine("d4.ToUniversalTime: " + d4.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d5: " + d5);
            Console.WriteLine("d5.Kind: " + d5.Kind);
            Console.WriteLine("d5.ToLocalTime: " + d5.ToLocalTime());
            Console.WriteLine("d5.ToUniversalTime: " + d5.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d5.ToString("yyyy-MM-ddTHH:mm:ssZ")); //cuidado!
            Console.WriteLine(d5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

        }
    }
}
