using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Capitulo6___Bridges
{
    public class EnviaPorSms : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviano a mensagem por SMS");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
