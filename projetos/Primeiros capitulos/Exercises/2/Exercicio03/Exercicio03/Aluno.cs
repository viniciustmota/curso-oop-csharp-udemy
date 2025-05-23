using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public void AvaliaAluno()
        {
            double soma = (Nota1+ Nota2+ Nota3);
            Console.WriteLine($"NOTA FINAL = {soma.ToString("F2", CultureInfo.InvariantCulture)}");
            if(soma > 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {(60.0 - soma).ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }

    }
}
