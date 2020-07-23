using System;
using System.Diagnostics;

namespace _01._3.Finalizador
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Livro livro = new Livro();
            }

            GC.Collect();
            
            Console.ReadKey();
        }
    }

    class Livro
    {
        static int UltimoId = 0;
        public string Introducao { get; set; }
        public string Texto { get; set; }
        public string Conclusao { get; set; }
        public int Id { get; }

        public Livro()
        {
            UltimoId++;
            Id = UltimoId;
            Trace.WriteLine("Livro " + Id + " está sendo criado");
        }

        ~Livro()
        {
            // Liberar somebte os recursos não gerenciados
            // Recursos de outras linguagens como algo criado em C ou C++ por exemplo.
            // Este finalizador é apenas um exemplo, não haveria a necessidade de implementar o finlaidador
            // na classe Livro
            // O uso de finalizador torna a execução mais lenta.
            Trace.WriteLine("Livro " + Id + " está sendo finalizado");
        }
    }
}
