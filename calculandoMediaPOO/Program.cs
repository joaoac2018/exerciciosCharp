﻿using System;

namespace calculandoMediaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos alunos você quer cadastrar: ");
            int numerosAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[numerosAlunos];

            for(int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Aluno " + (i + 1) + " Nome...: ");
                string nome = Console.ReadLine();

                Console.Write("Aluno " + (i + 1) + " provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.Write("Insira as notas do aluno " + nome);
                alunos[i].InserirNotas();
            }

            Console.Clear();
            double mediaGeral = 0;
            foreach(Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno " + aluno.Nome);
                Console.WriteLine("Media " + aluno.Media);
                Console.WriteLine();

                mediaGeral += aluno.Media;
            }

            double resultadofinal = mediaGeral / alunos.Length;
            Console.WriteLine("Media geral dos alunos: " + resultadofinal);
            Console.ReadKey();
            
        }
    }
}
