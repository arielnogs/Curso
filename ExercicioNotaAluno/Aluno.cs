using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ExercicioNotaAluno
{
    class Aluno
    {
        public double Nota1, Nota2, Nota3, NotaFinal, Restam;
        public string resultfim, Nome;

        public void Resultado()
        {
            NotaFinal = (Nota1 + Nota2 + Nota3);

            if (NotaFinal >= 60.00)
            {
                resultfim = "APROVADO";
            }
            else
            {

                Restam = 60.00 - NotaFinal;
                resultfim = "REPROVADO FALTAM " + Restam.ToString("F2") + " PONTOS";

            }

        }

        public override string ToString()
        {
            return "Nota Final=" + NotaFinal.ToString("F2", CultureInfo.InvariantCulture) + " " +
                resultfim;
        }
    }
}
