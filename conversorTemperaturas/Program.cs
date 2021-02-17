using System;

namespace conversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celc, Fahr, Kelv;
            Console.WriteLine("## Conversor de temperatura ##");
            Console.WriteLine("Digite a tempreatura em graus celcius:");
            Celc = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");

            //Calculo das temperaturas
            Fahr = (Celc * 9 / 5) + 32;
            Kelv = Celc + 273.15;

            Console.WriteLine($"{Celc} graus celcius é = {Fahr} graus fahrenheit");
            Console.WriteLine($"{Celc} graus celcius é = {Kelv} graus kelvin");
            Console.WriteLine("------------------------");
            Console.ReadKey();

        }
    }
}
