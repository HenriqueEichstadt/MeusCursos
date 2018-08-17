using CursoDesignPatterns.Decorator;
using CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability;
using CursoDesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Imposto impostos = new ImpostoMuitoAlto(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            Console.WriteLine(impostos.Calcula(orcamento));

            /*Imposto iss = new ISS(new ICMS());
            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);
            Console.ReadKey();*/



            /* IDesconto d1 = new DescontoPorCincoItens();
             IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
             IDesconto d3 = new DescontoPorVendaCasada();
             IDesconto d4 = new SemDesconto();

             d1.Proximo = d2;
             d2.Proximo = d3;
             d3.Proximo = d4;

             Orcamento orcamento = new Orcamento(500.0);

             double desconto = d1.Desconta(orcamento);
             Console.WriteLine(desconto);
             Console.ReadKey();*/

            /*CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
      
            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine("Desconto de:" + desconto);

            */
        }
    }
}
