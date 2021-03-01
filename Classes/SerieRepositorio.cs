using System.Collections.Generic;
using app_cadastro_series.Interfaces;

namespace app_cadastro_series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie serie)
        {
            listaSerie[id] = serie;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie serie)
        {
            listaSerie.Add(serie);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoTd()
        {
            return listaSerie.Count;
        }

        public Serie RetornoPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
