using CursoDesignPatterns2.Capitulo1;
using CursoDesignPatterns2.Capitulo2;
using CursoDesignPatterns2.Capitulo3___Memento;
using CursoDesignPatterns2.Capitulo4___Interpreter;
using CursoDesignPatterns2.Capitulo5___Visitor;
using CursoDesignPatterns2.Capitulo6___Bridges;
using CursoDesignPatterns2.Capitulo7___Command;
using CursoDesignPatterns2.Capitulo8___Adapter;
using CursoDesignPatterns2.Capitulo9___Façades_e_Singletons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CursoDesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            String cpf = "1234";

            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = facade.BuscaCliente(cpf);

            var fatura =  facade.CriaFatura(cliente, 5000);
            facade.GeraCobranca(tipo.Boleto, fatura);
            
            /*   Aula 8
            Cliente cliente = new Cliente();

            cliente.Nome = "Henrique";
            cliente.Endereco = "Rua 7 de Setembro";
            cliente.DataDeNascimento = DateTime.Now;

            String xml = new GeradorDeXml().GeraXml(cliente);

            Console.WriteLine(xml);
            */

            /*   Aula 7
            FIlaDeTrabalho fila = new FIlaDeTrabalho();
            Pedido pedido1 = new Pedido("João", 100);
            Pedido pedido2 = new Pedido("João", 200);
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
            */

            /*   Aula 6
            IMensagem mensagem = new MensagemAdministrativa("Henrique");
            IEnviador enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();
            */

            /*  Aula 5
            // ( 1 + 100 ) + 10 + ( 20 - 10 )

            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            IExpressao soma = new Soma(esquerda, direita);
            
            Console.WriteLine(soma.Avalia());
            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);
            */

            /*
            // ( 1 + 100 ) + 10 + ( 20 - 10 )

            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            IExpressao soma =  new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());
            */

            /*
            Historico historico = new Historico();


            Contrato c = new Contrato(DateTime.Now, "Victor", TipoContrato.Novo);
            historico.Adiciona(c.SalvaEstado());
           
            c.Avanca();

            historico.Adiciona(c.SalvaEstado());

            c.Avanca();

            historico.Adiciona(c.SalvaEstado());

            Console.WriteLine("Tipo do contrato   " + c.Tipo);

            Console.WriteLine("histórico do contrato   " + historico.Pega(2).Contrato.Tipo);
            */
// Aula 2
            /*
            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>()
            {
            
            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            };

            Piano piano = new Piano();
            piano.Toca(musica);
            */

            //Aula 1
            /* 
            // Abrir a conexão com o banco de dados
            IDbConnection conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela";
            */

        }
    }
}




