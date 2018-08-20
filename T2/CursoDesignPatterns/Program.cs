using CursoDesignPatterns.Builder;
using CursoDesignPatterns.Decorator;
using CursoDesignPatterns.Muitos_Descontos_e_o_Chain_of_Responsability;
using CursoDesignPatterns.Observer;
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

            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador.AdicionaAcao(new Multiplicador(2));
            criador.AdicionaAcao(new Multiplicador(3));
            criador.AdicionaAcao(new Multiplicador(5.5));

            NotaFiscal notaFiscal = criador.ParaEmpresa("benner")
                .ComCnpj("123.213.354/0001-31")
                .Com(new ItemDaNota("item 1", 1000.0))
                .Com(new ItemDaNota("item 2", 250.0))
                .Com(new ItemDaNota("item 3", 399.0))
                .ComObservacoes("entregar notaFiscal via email")
                .Constroi();


            /* NotaFiscalBuilder criador = new NotaFiscalBuilder();
             criador
                 .ParaEmpresa("Caelum Ensino e inovação")
                 .ComCnpj("23.4654/0001.13")
                 .Com(new ItemDaNota("item 1", 100.0))
                 .Com(new ItemDaNota("item 2", 200.0))
                 .ComObservacoes("uma observação qualquer");

             criador.AdicionaAcao(new EnviadorDeEmail());
             criador.AdicionaAcao(new EnviadorDeSms());
             criador.AdicionaAcao(new NotaFiscalDAO());

             NotaFiscal nf = criador.Constroi();

             Console.WriteLine(nf.ValorBruto);
             Console.WriteLine(nf.Impostos);*/


            Console.ReadKey();

            /*Orcamento reforma = new Orcamento(500);

            Console.WriteLine("Valor Inicial " + reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine("Com desconto extra: " +reforma.Valor);

            reforma.Aprova();

            reforma.AplicaDescontoExtra();
            Console.WriteLine("Com desconto extra depois de aprovado: " + reforma.Valor);

            reforma.Finaliza();
            
            Console.ReadKey();*/

            /*Imposto impostos = new ImpostoMuitoAlto(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            Console.WriteLine(impostos.Calcula(orcamento));*/

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
