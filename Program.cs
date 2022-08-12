using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Soma()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma entre {v1} e {v2} é igual a {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração entre {v1} e {v2} é igual a {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão entre {v1} e {v2} é igual a {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação entre {v1} e {v2} é igual a {resultado}");
            Console.ReadKey();
            Menu();

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------- Escolha uma operação ---------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------------------------------------");
            Console.Write("Seleciona uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
    }
}
