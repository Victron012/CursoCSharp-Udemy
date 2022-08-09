using System;

namespace Propriedades_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            TimeSpan t = new TimeSpan(2, 3, 4, 7, 11);
            
            TimeSpan t4 = new TimeSpan(1,30,10);
            TimeSpan t5 = new TimeSpan(0,10,5);

            TimeSpan soma = t4.Add(t5);
            TimeSpan dif = t4.Subtract(t5);
            TimeSpan mult = t5.Multiply(2.0);
            TimeSpan div = t5.Divide(2.0);


            Console.WriteLine("1)TimeSpan.MaxValue: "+t1);
            Console.WriteLine("2)TimeSpan.MinValue: " + t2);
            Console.WriteLine("3)TimeSpan.Zero: " + t3);
            Console.WriteLine("4)TimeSpan: " + t);
            Console.WriteLine("5)Days: " + t.Days);
            Console.WriteLine("6)Hours: " + t.Hours);
            Console.WriteLine("7)Minutes: " + t.Minutes);
            Console.WriteLine("8)Milliseconds: " + t.Milliseconds);
            Console.WriteLine("9)Ticks: " + t.Ticks);

            Console.WriteLine("10)TotalDays: " + t.TotalDays);
            Console.WriteLine("11)TotalHours: " + t.TotalHours);
            Console.WriteLine("12)TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("13)TotalMilliseconds: " + t.TotalMilliseconds);

            Console.WriteLine("---------Operações-----------");
            Console.WriteLine("14)TimeSpan.Add: " + soma);
            Console.WriteLine("15)TimeSpan.Subtract: " + dif);
            Console.WriteLine("16)TimeSpan.Multiply(2): " + mult);
            Console.WriteLine("17)TimeSpan.Divide(2): " + div);

        }
    }
}
