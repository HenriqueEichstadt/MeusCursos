using ByteBank.Core.Repository;
using ByteBank.View;
using ByteBank.View.Processamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ByteBank.Core.Model;

namespace ByteBank.View.Processamento.Aulas
{
    public class ProcessamentoAula2 : ProcessamentoBase
    {
        public ProcessamentoAula2(MainWindow mainWindow) : base(mainWindow)
        {
        }

        public override void Executar()
        {
            // Obter a thread principal da aplicação
            var taskSchedulerUI = TaskScheduler.FromCurrentSynchronizationContext();
            MainWindow.BtnProcessar.IsEnabled = false;

            var contas = R_Repositorio.GetContaClientes();

            var resultado = new List<string>();

            AtualizarView(new List<string>(), TimeSpan.Zero);

            var inicio = DateTime.Now;

            var contasTarefas = contas.Select(conta => 
            {
                return Task.Factory.StartNew(() => 
                {
                    var resultadoConta = R_Servico.ConsolidarMovimentacao(conta);
                    resultado.Add(resultadoConta);
                });
            }).ToArray();



            Task.WhenAll(contasTarefas)
                .ContinueWith(task =>
                {
                    var fim = DateTime.Now;
                    AtualizarView(resultado, fim - inicio);
                }, taskSchedulerUI)
                .ContinueWith(task => 
                {
                    MainWindow.BtnProcessar.IsEnabled = true;   
                }, taskSchedulerUI);

           
        }

        public override void Cancelar() { }

    }

}