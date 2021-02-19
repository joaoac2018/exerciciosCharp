using System;

namespace sequenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int valores, numero1 = 0, numero2 = 1, resultadoSeq = 0;

            Console.Write("Quantos valores você deseja pra sequência: ");
            valores = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------");
            
            Console.WriteLine("Sequência de fibonacci com " + valores + " valores");
            for(int i = 0; i < valores; i++)
            {
                if(i < valores - 1)
                {
                    Console.Write(numero1 + ", ");
                }
                else
                {
                    Console.Write(numero1);
                }
                resultadoSeq = numero1 + numero2;
                numero1 = numero2;
                numero2 = resultadoSeq;
            }
            Console.ReadKey();
        }
    }
}
