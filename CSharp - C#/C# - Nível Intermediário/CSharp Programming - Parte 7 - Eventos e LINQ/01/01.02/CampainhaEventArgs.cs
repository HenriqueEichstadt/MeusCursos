using System;

namespace _01_02
{
    public class CampainhaEventArgs : EventArgs
    {
        public string Apartamento { get; }

        public CampainhaEventArgs(string apartamento)
        {
            Apartamento = apartamento;
        }
    }
}