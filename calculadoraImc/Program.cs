using System;

namespace calculadoraImc
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double valorIMC;

            Console.Write("Informe o seu peso em kg: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a sua altura em metros: ");
            altura = double.Parse(Console.ReadLine());

            valorIMC = peso / (altura * altura);

            if(valorIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Abaixo do peso.");
            }
            else if (valorIMC >= 20 && valorIMC <= 24)
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Peso normal.");
            }
            else if (valorIMC >= 25 && valorIMC <= 29)
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Acima do peso.");
            }
            else if (valorIMC >= 30 && valorIMC <= 34)
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Obeso.");
            }
            else
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Muito obeso.");
            }

            Console.ReadKey();
             
        }
    }
}
