using System;
using System.Globalization;

namespace ExercicioNotaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno();

            Console.Write("Nome do Aluno: ");
            A.Nome = Console.ReadLine();

            Console.WriteLine("Digite as rês notas do aluno: ");
            A.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Resultado();
            Console.Write(A);




        }
    }
}
