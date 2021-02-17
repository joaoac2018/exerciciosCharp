using System;

namespace multiplicacaoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2,3];//inicializando a primeira matriz
            int[,] matriz2 = new int[3,2];//inicializando a segunda matriz
            int[,] matrizResultado = new int[2,2];//inicializando a matriz que armazena os resultados

            Console.WriteLine("Preencha a primeira matriz");
            for(int linha = 0; linha < 2; linha++)
            {
                for(int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("1º matriz na posição[" + linha + "][" + coluna + "]: ");
                    matriz1[linha,coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreeencha a segunda matriz");
            for(int linha = 0; linha < 3; linha++)
            {
                for(int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("2º matriz na posição[" + linha + "][" + coluna + "]: ");
                    matriz2[linha,coluna] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nResultado da matriz 1 x matriz 2");
            matrizResultado[0,0] = (matriz1[0,0] * matriz2[0,0])
                                 + (matriz1[0,1] * matriz2[1,0])
                                 + (matriz1[0,2] * matriz2[2,0]);

            matrizResultado[1,0] = (matriz1[1,0] * matriz2[0,0])
                                 + (matriz1[1,1] * matriz2[1,0])
                                 + (matriz1[1,2] * matriz2[2,0]);                        

            matrizResultado[0,1] = (matriz1[0,0] * matriz2[0,1])
                                 + (matriz1[0,1] * matriz2[1,1])
                                 + (matriz1[0,2] * matriz2[2,1]);

            matrizResultado[1,1] = (matriz1[1,0] * matriz2[0,1])
                                 + (matriz1[1,1] * matriz2[1,1])
                                 + (matriz1[1,2] * matriz2[2,1]);

            Console.WriteLine("[" + matrizResultado[0,0] + "][" + matrizResultado[0,1] + "]");
            Console.WriteLine("[" + matrizResultado[1,0] + "][" + matrizResultado[1,1] + "]"); 
            
            Console.ReadKey();
        }
    }
}
