using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soma();
            // Subtracao();
            // Divisao();
            Multiplicacao();
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

        }
    }
}
