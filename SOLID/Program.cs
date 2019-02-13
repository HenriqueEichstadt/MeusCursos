using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<ContaComum> contas = ContasDoBanco();

            foreach (ContaComum conta in contas)
            {
                conta.Deposita(120);
                conta.SomaInvestimento();

                Console.WriteLine("Novo saldo: " + conta.Saldo);
            }

            Console.ReadLine();
        }

        private static IList<ContaComum> ContasDoBanco()
        {
            List<ContaComum> contas = new List<ContaComum>();
            contas.Add(umaContaComum(100));
            contas.Add(umaContaComum(150));
            contas.Add(umaContaEstudante(100));
            return contas;
        }

        private static ContaEstudante umaContaEstudante(double saldo)
        {
            ContaEstudante conta = new ContaEstudante();
            conta.Deposita(saldo);
            return conta;
        }

        private static ContaComum umaContaComum(double saldo)
        {
            ContaComum conta = new ContaComum();
            conta.Deposita(saldo);
            return conta;
        }

        /* Aula 3
        Compra compra = new Compra(500, "Santa Catarina");
        CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Transportadora());

        double resultado = calc.Calcula(compra);

        Console.WriteLine("O preco da compra é  :" + resultado);
        Console.ReadKey();
        */

        /* Aula 2
        EnviadorDeEmail enviadorEmail = new EnviadorDeEmail();
        NotaFiscalDAO nfDao = new NotaFiscalDAO();
        IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();
        acoes.Add(new EnviadorDeEmail());
        acoes.Add(new NotaFiscalDAO());
        acoes.Add(new SAP());
        GeradorDeNotaFiscal gnf = new GeradorDeNotaFiscal(acoes);
        Fatura fatura = new Fatura(200, "Henrique");
        gnf.Gera(fatura);
        Console.ReadKey();
        */


        /* Aula 1
        CalculadoraDeSalario cs = new CalculadoraDeSalario();
        Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000);
        double resultado;

        resultado = cs.calcula(funcionario);

        Console.WriteLine("O salário de um desenvolvedor que ganha 2000 bruto é:   " + resultado);
        Console.ReadKey();
        */
    }
}

