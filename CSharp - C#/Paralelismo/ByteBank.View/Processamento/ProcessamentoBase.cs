using ByteBank.Core.Repository;
using ByteBank.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ByteBank.View.Processamento
{
    public abstract class ProcessamentoBase
    {
        public ContaClienteRepository R_Repositorio { get; }
        public ContaClienteService R_Servico { get; }
        public CancellationTokenSource Cts { get; set; }
        public MainWindow MainWindow { get; }

        public ProcessamentoBase(MainWindow mainWindow)
        {
            R_Repositorio = new ContaClienteRepository();
            R_Servico = new ContaClienteService();
            MainWindow = mainWindow;
        }

        public abstract void Executar();

        public abstract void Cancelar();

        public void LimparView()
        {
            MainWindow.LstResultados.ItemsSource = null;
            MainWindow.TxtProgresso = null;
            MainWindow.PgsProgresso.Value = 0;
        }

        protected virtual void AtualizarView(IEnumerable<String> result, TimeSpan elapsedTime)
        {
            var tempoDecorrido = $"{ elapsedTime.Seconds }.{ elapsedTime.Milliseconds} segundos!";
            var mensagem = $"Processamento de {result.Count()} clientes em {tempoDecorrido}";

            MainWindow.LstResultados.ItemsSource = result;
            MainWindow.TxtTempo.Text = mensagem;
        }
    }
}
