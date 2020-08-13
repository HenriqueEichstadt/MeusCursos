using System;

namespace _01_01
{
    public class Campainha
    {
        public Action OnCampainhaTocou { get; set; }
            
        public void Tocar()
        {
            if(OnCampainhaTocou != null)
                OnCampainhaTocou();
        }
    }
}