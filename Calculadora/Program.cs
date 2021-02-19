using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;
            char operacao;

            Console.WriteLine("Digite o primeiro numero");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            numero2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a operação (+ - * / ): ");
            operacao = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                default:
                    Console.WriteLine("Erro, opção inválida");
                break;

                case '+':
                     resultado = numero1 + numero2;
                     Console.WriteLine("O resultado da soma é: " + resultado);
                     break;
                case '-':
                     resultado = numero1 - numero2;
                     Console.WriteLine("O resultado da subtração: " + resultado);
                     break;
                case 'x':
                     resultado = numero1 * numero2;
                     Console.WriteLine("O resultado da multiplicação é: ");
                     break;
                case '/':
                     resultado = numero1 * numero2;
                     Console.WriteLine("O resultado da divisão é: ");
                     break;
            }

            Console.ReadKey();
        }
    }
}
