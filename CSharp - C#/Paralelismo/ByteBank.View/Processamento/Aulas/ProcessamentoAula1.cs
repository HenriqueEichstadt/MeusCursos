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
    public class ProcessamentoAula1 : ProcessamentoBase
    {
        public ProcessamentoAula1(MainWindow mainWindow) : base(mainWindow)
        {
        }

        public override void Executar()
        {
            var contas = R_Repositorio.GetContaClientes();

            var contasQuantidadePorThread = contas.Count() / 4;
            
            var contas_part1 = contas.Take(contasQuantidadePorThread);
            var contas_part2 = contas.Skip(contasQuantidadePorThread).Take(contasQuantidadePorThread);
            var contas_part3 = contas.Skip(contasQuantidadePorThread * 2).Take(contasQuantidadePorThread);
            var contas_part4 = contas.Skip(contasQuantidadePorThread * 3).Take(contasQuantidadePorThread);
            

            var resultado = new List<string>();

            AtualizarView(new List<string>(), TimeSpan.Zero);

            var inicio = DateTime.Now;

            var thread_parte_1 = CriarThread(resultado, contas_part1);
            var thread_parte_2 = CriarThread(resultado, contas_part2);
            var thread_parte_3 = CriarThread(resultado, contas_part3);
            var thread_parte_4 = CriarThread(resultado, contas_part4);

            thread_parte_1.Start();
            thread_parte_2.Start();
            thread_parte_3.Start();
            thread_parte_4.Start();

            while (thread_parte_1.IsAlive 
                   || thread_parte_2.IsAlive
                   || thread_parte_3.IsAlive
                   || thread_parte_4.IsAlive)
            {
                Thread.Sleep(250);
                // Não vou fazer nada
            }

            var fim = DateTime.Now;

            AtualizarView(resultado, fim - inicio);
        }

        private Thread CriarThread(List<string> resultado, IEnumerable<ContaCliente> contas)
        {
            var listContas = contas.ToList();
            return new Thread(() =>
            {
                foreach (var conta in listContas)
                {
                    Executar(resultado, listContas);
                }
            });
        }
        
        private void Executar(List<string> resultado, IEnumerable<ContaCliente> contas)
        {
            foreach (var conta in contas.ToArray())
            {
                var resultadoProcessamento = R_Servico.ConsolidarMovimentacao(conta);
                resultado.Add(resultadoProcessamento);
            }
        }
    }
}
