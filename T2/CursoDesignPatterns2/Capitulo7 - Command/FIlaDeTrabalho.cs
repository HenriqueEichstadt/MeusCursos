using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Capitulo7___Command
{
    public class FIlaDeTrabalho
    {
        private IList<IComando> Comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            this.Comandos.Add(comando);
        }
        public void Processa()
        {
            foreach (var comando in this.Comandos)
            {
                comando.Executa();
            }
        }
    }
}
