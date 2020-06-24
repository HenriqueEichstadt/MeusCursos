using System;

namespace _01.ByteBank
{
    public class Emprestimo
    {
        private int _prazo;
        private const int PrazoMaximoPagamentoAnos = 5;
        private const decimal Juros = 0.034m;

        private string _codigoContrato;

        private bool ValidarCodigo(string codigoContrato)
        {
            bool codigoContratoValido = true;
            foreach (var caractere in codigoContrato)
            {
                //só é válido se for numérico ou maiúscula
                bool numerico = Char.IsDigit(caractere);
                bool maiuscula = Char.IsUpper(caractere);
                
                bool valido = numerico || maiuscula;
                if (!(valido))
                {
                    codigoContratoValido = false;
                    break;
                }
            }

            return codigoContratoValido;
        }

        public Emprestimo(string codigoContrato)
        {
            if (ValidarCodigo(codigoContrato))
            {
                _codigoContrato = codigoContrato;
                Console.WriteLine($"Novo empréstimo com código: {codigoContrato}");    
            }
            else
            {
                // lançar uma exceção
            }
        }

        public event PrazoMaximoEstouradoHandler OnPrazoMaximoEstourado;

        public int Prazo
        {
            get
            {
                return _prazo;
            }
            set
            {
                if (value > PrazoMaximoPagamentoAnos)
                {
                    OnPrazoMaximoEstourado?.Invoke(this, new EventArgs());
                    return;
                }
                
                _prazo = value;
                Console.WriteLine($"novo prazo: {_prazo}");
            }
        }

        public decimal CalcularJuros(decimal valor, int prazo)
        {
            decimal valorJuros;
            decimal taxaJuros = 0;

            //1) se o prazo é maior que zero E menor que 5 E
            //o valor é menor que 7 mil, a taxa de juros é 3,5%
            //   1.1) senão, se o prazo for maior que 5 
            //        E o valor for maior que 7 mil, a taxa é 7,5%
            //   1.2) senão, a taxa de juros é 8,75%

            if (prazo > 0 && prazo < 5 && valor < 7000)
            {
                taxaJuros = 0.035m;
            }
            else if (prazo > 5 && valor > 7000)
            {
                taxaJuros = 0.075m;
            }
            else
            {
                taxaJuros = 0.0875m;
            }
            
            valorJuros = valor * taxaJuros * prazo;
            Console.WriteLine($"valorJuros: {valorJuros}");
            return valorJuros;
        }
    }

    public delegate void PrazoMaximoEstouradoHandler(object source, EventArgs e);
}