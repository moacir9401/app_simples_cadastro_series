using System.Collections.Generic;

namespace DIO.series
{
  public class SerieRepositorio : IRepositorio<Serie>
  {
    private List<Serie> listaSerie = new List<Serie>();
    public void Atualizar(int id, Serie entidade)
    {
     listaSerie[id] = entidade;
    }

    public void excluir(int id)
    {
     listaSerie[id].Excluir();
    }

    public void Inserir(Serie entidade)
    {
     listaSerie.Add(entidade);
    }

    public List<Serie> lista()
    {
     return listaSerie;
    }

    public int ProximoId()
    {
      return listaSerie.Count;
    }

    public Serie RetornarPorId(int id)
    {
       return listaSerie[id];
    }
  }
}