using CursoDesignPatterns2.Capitulo1;
using CursoDesignPatterns2.Capitulo2;
using CursoDesignPatterns2.Capitulo3___Memento;
using CursoDesignPatterns2.Capitulo4___Interpreter;
using CursoDesignPatterns2.Capitulo5___Visitor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ( 1 + 100 ) + 10 + ( 20 - 10 )

            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());
            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);

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




