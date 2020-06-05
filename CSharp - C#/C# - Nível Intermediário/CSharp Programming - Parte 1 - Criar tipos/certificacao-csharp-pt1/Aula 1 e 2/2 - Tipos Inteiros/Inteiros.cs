using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            // System.Char
            char resposta = 'S';


            byte nivelDeAzul = 0xFF; // Representação do número 255 em decimal;
            //nivelDeAzul = -3;

            // System.Int16
            short passageirosVoo = 230;

            // System.Int32
            int populacao = 1500;
            populacao = -2300;

            // System.Int64
            long populacaoDoBrasil = 207_660_929;

            // System.Sbyte
            sbyte nivelDeBrilho = 127;
            nivelDeBrilho = -127;

            // System.UInt16
            ushort passageirosNavio = 230;

            // System.UInt32
            uint estoque = 1500;

            // System.UInt64
            ulong populacaoDoMundo = 7_000_000_000;

            Console.WriteLine($"resposta {resposta}");
            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");
            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");

            /// tentando adicionar um valor hexademimal de 2 bytes em tipo que suporta apenas 1 byte
            //nivelDeAzul = 0xFFFF; // = 65535 em decimal

            /// tentando adicionar um valor que ultrapassa o limite de armazenamento do tipo short
            //passageirosVoo = 230000;

            /// tentando adicionar um valor que ultrapassa o limite de armazenamento do tipo int
            //populacao = 15000000000;

            /// tentando adicionar um valor negativo ao tipo ushort
            //passageirosNavio = -15;

            /// tentando adicionar um valor negativo ao tipo uint
            //uint estoque = -2300;

            /// tentando armazenar valores com casa decimal no tipo long
            //populacaoDoBrasil = 207_660_929.345;

        }
    }
}
