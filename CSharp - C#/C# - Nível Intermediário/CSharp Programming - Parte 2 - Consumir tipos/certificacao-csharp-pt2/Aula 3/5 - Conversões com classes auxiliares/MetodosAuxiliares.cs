using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            string textoDigitado = "123";
            //int numeroConvertido = textoDigitado;

            int numeroConvertido = int.Parse(textoDigitado);
            Console.WriteLine($"numeroConvertido: {numeroConvertido}");

            textoDigitado = "abc";
            //numeroConvertido = int.Parse(textoDigitado);
            
            if(int.TryParse(textoDigitado, out numeroConvertido))
            {
                Console.WriteLine($"numeroConvertido: {numeroConvertido}");
            }
            else
            {
                Console.WriteLine("texto não é um número");
            }

            textoDigitado = "123,45";
            decimal.TryParse(textoDigitado, 
                NumberStyles.Currency,
                CultureInfo.CurrentCulture, //pt-BR
                out decimal valorConvertido);
            Console.WriteLine($"valorConvertido: {valorConvertido}");
        }
    }
}
