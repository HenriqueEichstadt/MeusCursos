using ByteBank.Core.Repository;
using ByteBank.View;
using ByteBank.View.Processamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.View.Processamento.Aula1
{
    public class ProcessamentoAula1 : ProcessamentoBase
    {
        public ProcessamentoAula1(MainWindow mainWindow) : base(mainWindow)
        {
        }

        public override void Executar()
        {
            var contas = R_Repositorio.GetContaClientes();
            // 4:42 min de aula
            var contas_part1 = contas.Take(contas.Count() / 2);
            var contas_part2 = contas.Skip(contas.Count() / 2);

            var resultado = new List<string>();

            AtualizarView(new List<string>(), TimeSpan.Zero);

            var inicio = DateTime.Now;

            foreach (var conta in contas)
            {
                var resultadoConta = R_Servico.ConsolidarMovimentacao(conta);
                resultado.Add(resultadoConta);
            }

            var fim = DateTime.Now;

            base.AtualizarView(resultado, fim - inicio);
        }
    }
}
