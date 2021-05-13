using System.Collections.Generic;

namespace DIO.series
{
    public interface IRepositorio<T>
    {
         List<T> lista();
         T RetornarPorId(int id);
         void Inserir(T entidade);
         void excluir(int id);
         void Atualizar(int id, T entidade);
         int ProximoId();
    }
}