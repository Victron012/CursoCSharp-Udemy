using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase, x, y, z, a, b, c, s, nome;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Escolha uma cor: ");
            x = Console.ReadLine();
            Console.WriteLine("Escolha uma cor: ");
            y = Console.ReadLine();
            Console.WriteLine("Escolha uma cor: ");
            z = Console.ReadLine();
            Console.WriteLine("Escolha 3 cores (com espaços): ");
            s = Console.ReadLine();

            string[] vet = s.Split(' ');

            a = vet[0];
            b = vet[1];
            c = vet[2];


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


            Console.WriteLine("Deseja ir para a próxima etapa? S/N");
            char i = char.ToUpper(char.Parse(Console.ReadLine()));

            if (i != 'S')
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();

            }

            int n1, idade;
            char ch, sexo;
            double n2, altura;


            Console.WriteLine("Digite sua idade: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu gênero (F/M): ");
            ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso: ");
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite seu nome, gênero, idade e altura separados por espaços: ");
            vet = Console.ReadLine().Split(' ');

            nome = vet[0];
            sexo = char.Parse(vet[1]);
            idade = int.Parse(vet[2]);
            altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("{0} do gênero {1} tem {2} anos e {3:F2}m de altura.", nome, sexo, idade, altura);

        }
    }
}
