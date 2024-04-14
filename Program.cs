using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando as variáveis que vão iniciar com valor padrão
            int num1, num2 = default(int);

            //titulo em C# da calculadora console
            Console.WriteLine("Calculadora console em C#  \r");
            Console.WriteLine("---------------------------\n");

            // Peça ao usuário para digitar o primeiro número.
            Console.WriteLine("Digite o primeiro número e pressione enter : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            //peça ao usuário para digitar o segundo número.
            Console.WriteLine("Digite o segundo número e pressione enter : ");
            num2  = Convert.ToInt32(Console.ReadLine());

            //peça ao usuário para escolher uma opção
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Escolha uma opção da lista a seguir : ");
            Console.WriteLine("\ta - Adição");
            Console.WriteLine("\ts - Subtração");
            Console.WriteLine("\tm - Multiplicação");
            Console.WriteLine("\td - Divisão");
            Console.WriteLine("Sua opção ?");
            Console.WriteLine("---------------------------\n");

            // Use uma instrução switch para fazer as contas.
            switch(Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Seu resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Seu resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Seu resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Seu resultado: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.WriteLine("---------------------------\n");
            //Aguarde a resposta do usuário antes de fechar
            Console.WriteLine("Aperte qualquer tecla para fechar o app calculadora console C#");
            Console.ReadKey();





        }
    }
}
