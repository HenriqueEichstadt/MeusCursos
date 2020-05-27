using ByteBank.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ByteBank.View.Processamento.Aulas
{
    public class ProcessamentoAula5 : ProcessamentoBase
    {
        public ProcessamentoAula5(MainWindow mainWindow) : base(mainWindow)
        {
        }

        public async override void Executar()
        {
            MainWindow.BtnProcessar.IsEnabled = false;

            Cts = new CancellationTokenSource();

            var contas = R_Repositorio.GetContaClientes();

            MainWindow.PgsProgresso.Maximum = contas.Count();

            LimparView();

            var inicio = DateTime.Now;

            MainWindow.BtnCancelar.IsEnabled = true;

            var progress = new Progress<string>(str =>
                MainWindow.PgsProgresso.Value++);

            try
            {
                var resultado = await ConsolidarContas(contas, progress, Cts.Token);

                var fim = DateTime.Now;
                AtualizarView(resultado, fim - inicio);
            }
            catch (OperationCanceledException)
            {
                MainWindow.TxtTempo.Text = "Operação cancelada pelo usuário";
            }
            finally
            {
                MainWindow.BtnProcessar.IsEnabled = true;
                MainWindow.BtnCancelar.IsEnabled = false;
            }
        }

        public override void Cancelar()
        {
            MainWindow.BtnCancelar.IsEnabled = false;
            Cts.Cancel();
        }

        private async Task<string[]> ConsolidarContas(IEnumerable<ContaCliente> contas, IProgress<string> reportadorDeProgresso, CancellationToken ct)
        {
            var tasks = contas.Select(conta =>
                Task.Factory.StartNew(() =>
                {
                    ct.ThrowIfCancellationRequested();

                    var resultadoConsolidacao = R_Servico.ConsolidarMovimentacao(conta, ct);

                    reportadorDeProgresso.Report(resultadoConsolidacao);

                    ct.ThrowIfCancellationRequested();

                    return resultadoConsolidacao;
                }, ct)
            );

            return await Task.WhenAll(tasks);
        }
    }
}
