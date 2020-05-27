using ByteBank.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.View.Processamento.Aulas
{
    class ProcessamentoAula3 : ProcessamentoBase
    {
        public ProcessamentoAula3(MainWindow mainWindow) : base(mainWindow)
        {
        }

        public async override void Executar()
        {
            MainWindow.BtnProcessar.IsEnabled = false;

            var contas = R_Repositorio.GetContaClientes();

            AtualizarView(new List<string>(), TimeSpan.Zero);

            var inicio = DateTime.Now;

            var resultado = await ConsolidarContas(contas);
           
            var fim = DateTime.Now;
            AtualizarView(resultado, fim - inicio);
            MainWindow.BtnProcessar.IsEnabled = true;
        }

        public override void Cancelar() { }

        private async Task<string[]> ConsolidarContas(IEnumerable<ContaCliente> contas)
        {
            var tasks = contas.Select(conta =>
                Task.Factory.StartNew(() => R_Servico.ConsolidarMovimentacao(conta))
            );

            return await Task.WhenAll(tasks);
        }
    }
}