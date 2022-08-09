using System;

namespace Propriedades_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine("14) ToLongDateString: " + d.ToLongDateString());
            Console.WriteLine("15) ToLongTimeString: " + d.ToLongTimeString());
            Console.WriteLine("16) ToShortDateString: " + d.ToShortDateString());
            Console.WriteLine("17) ToShortTimeString: " + d.ToShortTimeString());
            Console.WriteLine("18) ToString: " + d.ToString());
            Console.WriteLine("19) Mascara: " + d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("20) Mascara milisegundos: " + d.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Console.WriteLine("----------Operações---------");
            Console.WriteLine("Data original: " + d);
            Console.WriteLine("1) AddHours(2): " + d.AddHours(2));
            Console.WriteLine("2) AddMinutes(3): " + d.AddMinutes(3));
            Console.WriteLine("3) AddDays(7): " + d.AddDays(7));
            DateTime d1 = new DateTime(2000, 10, 18);
            TimeSpan t = d.Subtract(d1);
            Console.WriteLine("4) Subtract(7): " + t);
        }
    }
}
