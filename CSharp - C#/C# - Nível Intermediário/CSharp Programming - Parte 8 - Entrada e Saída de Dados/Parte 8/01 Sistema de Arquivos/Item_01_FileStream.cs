using System;
using System.IO;
using System.Text;

namespace Listings
{
    class Item_01_FileStream
    {
        static void XMain(string[] args)
        {

            FileStream fluxoSaida = new FileStream("ArquivoSaida.txt", FileMode.Create, FileAccess.Write);

            string mensagemSaida = "Olá. Alura!";

            byte[] array = Encoding.UTF8.GetBytes(mensagemSaida);
            int posicao = 0;
            int tamanho = mensagemSaida.Length;
            
            fluxoSaida.Write(array, posicao, tamanho);
            fluxoSaida.Close();

            fluxoSaida.Dispose();

            
            FileStream fluxoEntrada = new FileStream("ArquivoSaida.txt", FileMode.Open, FileAccess.Read);

            byte[] bytesLidos = new byte[fluxoEntrada.Length];

            fluxoEntrada.Read(bytesLidos, posicao, (int)fluxoEntrada.Length);

            var texto = Encoding.UTF8.GetString(bytesLidos);
            Console.WriteLine("Mensagem Lida: " + texto);

            fluxoEntrada.Dispose();
            
            
            Console.ReadKey();
        }
    }
}