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
            if(Lances.Count == 0 || podeDarLance(lance.Usuario))
            {
                Lances.Add(lance);
            }
        }

        private bool podeDarLance(Usuario usuario)
        {
            return !UltimoLanceDado().Usuario.Equals(usuario) && qtdLancesDo(usuario) < 5;
        }

        private int qtdLancesDo(Usuario usuario)
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
            return Lances[Lances.Count-1];
        }

    }
}