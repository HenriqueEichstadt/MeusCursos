using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Listings
{
    class Item_04_ArquivosComprimidos
    {
        static void Main(string[] args)
        {
            // Compactando arquivo em formato .zip
            using (var fluxoArquivo = new FileStream("Texto.zip", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (GZipStream compactador = new GZipStream(fluxoArquivo, CompressionMode.Compress))
                {
                    using (StreamWriter gravadorFluxo = new StreamWriter(compactador))
                    {
                        gravadorFluxo.Write("Olá, Alura! (gravado com StreamWriter)");
                    }     
                }
            }
            
            // Descompactando arquivo em formato .zip

            using (var fluxoArquivo = new FileStream("Texto.zip", FileMode.Open, FileAccess.Read))
            {
                using (var descompactador = new GZipStream(fluxoArquivo, CompressionMode.Decompress))
                {
                    using (StreamReader leitorFluxo = new StreamReader(descompactador))
                    {
                        string textoLido = leitorFluxo.ReadToEnd();
                        Console.WriteLine("Texto lido: {0}", textoLido);
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
