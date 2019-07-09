using System;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {

        public string Url { get; }
        private string _argumentos;
        
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
             throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
            Url = url;
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentoEmCaixaAlta = _argumentos.ToUpper();

            string termo = nomeParametro + "=";
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');
            
            return indiceEComercial.Equals(-1) ? resultado : _argumentos.Substring(indiceTermo + termo.Length);
        }
    }
}