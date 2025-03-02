using System;

namespace Calculator
{

    class Program
    {
        static void Main(string[] args)
        {
            MenuUsuario();
        }

        static void MenuUsuario()
        {
            Console.Clear();

            Console.WriteLine("Bem-Vindo a minha caculadora com C#, qual operalção deseja realizar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair :()");

            Console.WriteLine("________________________________________");
            Console.WriteLine("");

            Console.WriteLine("Selecione uma opção: ");

            short Escolha = short.Parse(Console.ReadLine());

            switch (Escolha)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Console.WriteLine("Obrigado por usar a calculadora!"); 
                Environment.Exit(0); break;
                default:
                    Console.WriteLine("Você digitou uma opção invalida, por favor veja as opções válidas!");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey(); MenuUsuario(); break;
            }
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

            Console.WriteLine("O resultado da soma é: " + (Number1 + Number2));
            Continuar();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Qual o primeiro valor? ");
            float Number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o segundo valor? ");
            float Number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("_________________________");
            Console.WriteLine();

            Console.WriteLine("O resultado da subtração é: " + (Number1 - Number2));
            Continuar();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Qual o primeiro valor? ");
            float Number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o segundo valor? ");
            float Number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("_________________________");
            Console.WriteLine();

            Console.WriteLine("O resultado da divisão é: " + (Number1 / Number2));
            Continuar();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Qual o primeiro valor? ");
            float Number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o segundo valor? ");
            float Number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("_________________________");
            Console.WriteLine();

            Console.WriteLine("O resultado da multiplicação é: " + (Number1 * Number2));
            Continuar();
        }
        static void Continuar()
        {
            Console.WriteLine("Deseja realizar outra operação? (S/N)");

            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                MenuUsuario();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Obrigado por usar a calculadora!");
                Environment.Exit(0);
            }
        }

    }
}