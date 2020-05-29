using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        private static void Main(string[] args)
        {
            Cliente Maria = new Cliente();
            Maria.CPF = "822.605.409-53";
            Maria.Nome = "Maria Hass Eichstadt";
            Maria.Profissao = "Mamãe querida";

            Console.WriteLine("O nome da cliente é: " + Maria.Nome + ". E o CPF dela é: " + Maria.CPF + ". E a profissão dela é: " + Maria.Profissao);

            Console.ReadLine();
        }

        public void FimDoCurso()
        {
            string padrao = @"[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            string textoDeTeste = "Meu nome é Henrique, me ligue em 9241-7413";

            var result = Regex.IsMatch(textoDeTeste, padrao);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public void ExtratorValorDeArgumentosURL()
        {
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";

            var extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);
            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor moedaDestino " + valor);
            Console.ReadLine();
        }

        private void UsandoIndexOf()
        {
            var url = "";
            int indiceInterrogacao = url.IndexOf('?');
            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
        }

        private void UsandoSubString()
        {
            var url = "";
            Console.WriteLine(url);
            string argumentos = url.Substring(7);
            Console.WriteLine(argumentos);
        }
    }
}
