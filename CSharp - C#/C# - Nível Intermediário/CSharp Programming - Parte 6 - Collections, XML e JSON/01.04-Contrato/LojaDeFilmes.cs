using System.Collections.Generic;
using System.Runtime.Serialization;

namespace _01._04
{
    [DataContract]
    public class LojaDeFilmes
    {
        [DataMember]
        public List<Diretor> Diretores = new List<Diretor>();
        
        [DataMember]
        public List<Filme> Filmes = new List<Filme>();
        public static void AdicionarFilme(Filme filme)
        {
            // Aqui vai a lógica de inserção de filme...
        }
    }

    [DataContract]
    public class Diretor
    {
        [DataMember]
        public string Nome { get; set; }
        
        [IgnoreDataMember]
        public int NumeroFilmes;
    }

    [DataContract]
    public class Filme
    {
        [DataMember]
        public Diretor Diretor { get; set; }
        
        [DataMember]
        public string Titulo { get; set; }
        
        [DataMember]
        public string Ano { get; set; }
    }
}
