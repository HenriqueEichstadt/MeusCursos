using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;

            // Nesta linha, número está sofrendo boxing
            object caixa = numero;

            Console.WriteLine(string.Concat("Resposta", numero, 57, true));
        }
    }
}
