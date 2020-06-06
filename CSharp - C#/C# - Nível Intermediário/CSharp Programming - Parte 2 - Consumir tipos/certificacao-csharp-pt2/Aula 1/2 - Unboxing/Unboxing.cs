using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;      // tipo de valor
            object caixa = numero; // boxing

            try
            {
                int unboxed = (int)caixa;
                
                Console.WriteLine("Unboxing Ok.");
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Erro: unboxing incorreto", e.Message);
            }
        }
    }
}
