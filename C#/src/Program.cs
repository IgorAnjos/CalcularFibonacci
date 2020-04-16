using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Vamos calcular a sequência dos números de FIBONACCI");

            do
            {
                NumberEntered();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Digite um número inteiro: ");

                var check = Console.ReadLine();
                int qntdade;
                bool isNum = int.TryParse(check, out qntdade);
                check = null;

                if (isNum && qntdade > 1)
                {
                    CalculateFibonacci(qntdade);
                    cont = again(cont);
                }
                else if (isNum && qntdade == 1)
                {
                    Console.WriteLine($"{qntdade} - {qntdade}");
                    cont = again(cont);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Por favor, digite um número inteiro e maior que 'Zero'.");
                }
            } while (cont == 0);
        }

        public static List<int> CalculateFibonacci(int qntdade)
        {
            List<int> fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < qntdade)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            int primeiro = 0;
            foreach (var number in fibonacciNumbers)
            {
                primeiro += 1;
                Console.WriteLine($"{primeiro} - {number}");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Total de {fibonacciNumbers.Count}");

            return fibonacciNumbers;
        }

        public static void NumberEntered()
        {
            Console.Clear();
            Console.WriteLine($"Quantos números deseja mostrar na sequência?");
        }

        public static int again(int _cont)
        {
            int cont = _cont;
            Console.WriteLine($"Desejar calcular novamente? \n >>> (Y) - Sim/Yes \n >>> (N) - Não/No \n ");
            ConsoleKeyInfo caracter = Console.ReadKey();
            Console.WriteLine();
            
            if (caracter.Key == ConsoleKey.Y)
                cont = 0;
            else
                cont = 1;

            return cont;
        }
    }
}
#region // Forma de Verificar o tipo de uma varivável
// TypeCode variavel2 = Type.GetTypeCode(variavel.GetType());
#endregion

