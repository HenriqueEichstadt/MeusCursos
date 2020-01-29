using System;
using System.Linq;

namespace Collections
{
    public class OperadoresDeConjuntosComLINQ
    {
        public void Examples()
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            // Concatenando duas sequências
            var consulta = seq1.Concat(seq2);

            // Unindo duas consultas
            // não adiciona valores duplicados (março/MARÇO)
            var consulta2 = seq1.Union(seq2);

            // União de duas consultas com comparador
            // mantém valores em comum (março/MARÇO)
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);

            
            // Intersecão de duas sequências
            // Trás apenas elementos em comum entre as sequências
            var consulta4 = seq1.Intersect(seq2);
            
            // Exceto: Elementos de seq1 que não estão em seq2
            var consulta5 = seq1.Except(seq2);
            
            
        }
    }
}