using System.Collections.Generic;
namespace Caelum.Leilao
{

    public class Leilao
    {

        public string Descricao { get; set; }
        public IList<Lance> Lances { get; set; }

        public Leilao(string descricao)
        {
            this.Descricao = descricao;
            this.Lances = new List<Lance>();
        }

        public void Propoe(Lance lance)
        {
            if (Lances.Count == 0 || PodeDarLance(lance.Usuario))
            {
                Lances.Add(lance);
            }
        } 

        private bool PodeDarLance(Usuario usuario)
        {
            return (!UltimoLanceDado().Usuario.Equals(usuario) && qtdDeLancesDo(usuario) < 5);
        }

        public void DobraLance(Usuario usuario)
        {
            Lance ultimoLance = UltimoLanceDo(usuario);
            if (ultimoLance != null)
            {
                Propoe(new Lance(usuario, ultimoLance.Valor * 2));
            }
        }
        private Lance UltimoLanceDo(Usuario usuario)
        {
            Lance ultimo = null;
            foreach (Lance lance in Lances)
            {
                if (lance.Usuario.Equals(usuario)) ultimo = lance;
            }

            return ultimo;
        }

        private int qtdDeLancesDo(Usuario usuario)
        {
            int total = 0;
            foreach (var l in Lances)
            {
                if (l.Usuario.Equals(usuario)) total++;
            }
            return total;
        }

        private Lance UltimoLanceDado()
        {
            return Lances[Lances.Count - 1];
        }
    }
}