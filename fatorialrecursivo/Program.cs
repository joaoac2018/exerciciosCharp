using System;

namespace fatorialrecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um numero para calcular o fatorial: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("O fatorial de " + num + " é " + fatorial(num));
            Console.ReadKey();         
        }
        static int fatorial(int num)
        {
            if(num <= 0)
            {
                return 1;
            }
            return num * fatorial(num - 1);

        }
    }
}
/*Como acontece o calculo fatorial de um numero, 
veja o exemplo com o numero 5 abaixo:
-5 * fatorial(4);
-4 * fatorial(3);
-3 * fatorial(2);
-2 * fatorial(1);
-1 * fatorial(0);
return 1;*/
