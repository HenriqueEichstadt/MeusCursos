using System;

namespace _01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Campainha campainha = new Campainha();
            
            // Adicionando métodos para escutar o evento
            campainha.OnCampainhaTocou += CampainhaTocou1;
            
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            // Removendo métodos que escutam o evento
            campainha.OnCampainhaTocou -= CampainhaTocou1;
            
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            Console.ReadKey();
        }

        public static void CampainhaTocou1()
        {
            Console.WriteLine("A campainha tocou.(1)");
        }
        
        public static void CampainhaTocou2()
        {
            Console.WriteLine("A campainha tocou.(2)");
        }
    }
}
