using System;

namespace _01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Campainha campainha = new Campainha();
            campainha.OnCampainhaTocou += CampainhaTocou1;
            campainha.OnCampainhaTocou += CampainhaTocou2;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar("101");

            campainha.OnCampainhaTocou -= CampainhaTocou1;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar("202");

            Console.ReadKey();
        }

        static void CampainhaTocou1(object sender, CampainhaEventArgs args)
        {
            Console.WriteLine($"A campainha tocou no apartamento {args.Apartamento}.(1)");
        }
        static void CampainhaTocou2(object sender, CampainhaEventArgs args)
        {
            Console.WriteLine($"A campainha tocou no apartamento {args.Apartamento}.(2)");
        }
    }

    class Campainha
    {
        public event EventHandler<CampainhaEventArgs> OnCampainhaTocou;

        public void Tocar(string apartamento)
        {
            if (OnCampainhaTocou != null)
            {
                OnCampainhaTocou(this, new CampainhaEventArgs(apartamento));
            }

        }
    }
}


