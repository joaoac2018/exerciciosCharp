using System;

namespace calculandoMediaPOO
{
    class Aluno
    {
        public string Nome { get; private set; }
        
        private double[] notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }
        public Aluno(string nome, int provas)
        {
            Nome = nome;
            notas = new double[provas];
        }
        
        public void InserirNotas()
        {
            for(int i = 0; i < notas.Length; i++)
            {
                Console.Write("Nota " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;
            for(int i = 0; i < notas.Length; i++)
            {
                total += notas[i];
            }
            return total / notas.Length;
        }
    }
}