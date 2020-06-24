using System;

namespace _01.ByteBank
{
    class ContaBancaria
    {
        private decimal _saldo = 0m;

        public ContaBancaria(decimal saldo)
        {
            this._saldo = saldo;
            Console.WriteLine(this);
        }

        public void SacarDinheiro(decimal quantia)
        {
            if (_saldo < quantia)
            {
                Console.WriteLine("Saldo insuficiente.");
                // Sai fora do método
                return;
            }

            Sacar(quantia);
            ImprimirComprovante();
        }

        private bool TemSaldoSuficiente(decimal quantia)
        {
            return quantia <= _saldo;
        }

        private void ImprimirComprovante()
        {
            Console.WriteLine("Comprovante impresso.");
        }

        private void Sacar(decimal quantia)
        {
            Console.WriteLine($"Sacando {quantia:C}");
            _saldo = _saldo - quantia;
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Saldo: {_saldo:C}";
        }
    }
}