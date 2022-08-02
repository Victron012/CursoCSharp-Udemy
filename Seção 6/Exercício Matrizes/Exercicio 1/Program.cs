using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count = 0;
            Console.WriteLine("Escolha o número da matriz: ");
            n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j<n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Diagonal principal");
            for(int i = 0; i<n; i++)
            {
                Console.Write(matriz[i, i]);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0) { count++; }
                }
            }
            Console.Write("Números negativos: " + count);
        }
    }
}
