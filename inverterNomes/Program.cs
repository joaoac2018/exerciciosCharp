using System;

namespace inverterNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, auxiliar;

            Console.WriteLine("Digite o primeiro nome");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite o segundo nome");
            nome2 = Console.ReadLine();

            Console.WriteLine("Digite o terceiro nome");
            nome3 = Console.ReadLine();

            Console.WriteLine("Digite o quarto nome");
            nome4 = Console.ReadLine();

            Console.WriteLine("--------########----------");

            //Aqui vai inverter as variaveis, usando uma variavel auxiliar.
            auxiliar = nome1;
            nome1 = nome4;
            nome4 = auxiliar;
            auxiliar = nome2;
            nome2 = nome3;
            nome3 = auxiliar;
            
            Console.WriteLine();
            Console.WriteLine("Nomes inseridos em sequencia invertida");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
            Console.ReadKey();
        }
    }
}
