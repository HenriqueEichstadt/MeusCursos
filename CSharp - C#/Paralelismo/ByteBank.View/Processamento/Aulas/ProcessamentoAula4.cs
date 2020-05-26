using ByteBank.Core.Model;
using ByteBank.View.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ByteBank.View.Processamento.Aulas
{
    public class ProcessamentoAula4 : ProcessamentoBase
    {
        public ProcessamentoAula4(MainWindow mainWindow) : base(mainWindow)
        {
        }

        public async override void Executar()
        {
            MainWindow.BtnProcessar.IsEnabled = false;

            var contas = R_Repositorio.GetContaClientes();

            MainWindow.PgsProgresso.Maximum = contas.Count();

            LimparView();

            var inicio = DateTime.Now;

            var progress = new Progress<string>(str =>
                MainWindow.PgsProgresso.Value++);

            var resultado = await ConsolidarContas(contas, progress);

            var fim = DateTime.Now;
            AtualizarView(resultado, fim - inicio);
            MainWindow.BtnProcessar.IsEnabled = true;
        }

        private async Task<string[]> ConsolidarContas(IEnumerable<ContaCliente> contas, IProgress<string> reportadorDeProgresso)
        {
            var tasks = contas.Select(conta =>
                Task.Factory.StartNew(() => 
                {
                    var resultadoConsolidacao = R_Servico.ConsolidarMovimentacao(conta);

                    reportadorDeProgresso.Report(resultadoConsolidacao);

                    return resultadoConsolidacao;
                })
            );

            return await Task.WhenAll(tasks);
        }
    }
}
