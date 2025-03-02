using System;

namespace Calculator
{

    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Qual o primeiro valor? ");
            float Number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o segundo valor? ");
            float Number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("_________________________");
            Console.WriteLine();

            Console.WriteLine("O resultado da soma é " + (Number1 + Number2));
        }
        
    }
}