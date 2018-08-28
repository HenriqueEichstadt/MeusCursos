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
}
