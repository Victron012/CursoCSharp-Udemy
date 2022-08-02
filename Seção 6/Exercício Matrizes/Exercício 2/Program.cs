using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, c, n;
            Console.Write("Quantas linhas e colunas terá a matriz: ");
            string[] s = Console.ReadLine().Split(' ');
            l = int.Parse(s[0]);
            c = int.Parse(s[1]);
            int[,] matriz = new int[l, c];

            for (int i = 0; i < l; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < c; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Qual número deseja procurar: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matriz[i, j] == n)
                    {
                        Console.WriteLine("Posição {0},{1}:", i, j);
                        if (j > 0) { Console.WriteLine("Esquerda: " + matriz[i,j-1]); }
                        if (j < c-1) { Console.WriteLine("Direita: "+matriz[i,j+1]); }
                        if (i > 0) { Console.WriteLine("Acima: "+matriz[i-1,j]); }
                        if (i < l-1) { Console.WriteLine("Abaixo: "+matriz[i+1,j]); }
                    }
                }
            }
        }
    }
}
