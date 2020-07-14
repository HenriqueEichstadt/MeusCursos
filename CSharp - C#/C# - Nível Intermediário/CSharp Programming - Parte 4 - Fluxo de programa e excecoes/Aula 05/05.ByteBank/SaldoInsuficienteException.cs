using System;
using System.Runtime.Remoting.Messaging;

namespace _05.ByteBank
{
    [Serializable]
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }

        public SaldoInsuficienteException(string message, Exception inner) : base(message, inner)
        {
        }

        protected SaldoInsuficienteException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
        
        public override string Message => "Saldo Insuficiente.";
    }
}